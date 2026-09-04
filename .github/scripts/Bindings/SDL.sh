#!/usr/bin/env bash
set +e

# Setup
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs/$NAME"
mkdir -p "$OUTPUTS"


# SDL
if [ ! -d "$BASEPATH/SDL" ]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL.git "$BASEPATH/SDL"
fi


# Files
FILES=(
  SDL_assert
  SDL_atomic
  SDL_asyncio
  SDL_audio
  SDL_bits
  SDL_blendmode
  SDL_camera
  SDL_clipboard
  SDL_cpuinfo
  SDL_dialog
  SDL_error
  SDL_events
  SDL_filesystem
  SDL_gamepad
  SDL_gpu
  SDL_guid
  SDL_haptic
  SDL_hidapi
  SDL_hints
  SDL_init
  SDL_iostream
  SDL_joystick
  SDL_keyboard
  SDL_keycode
  SDL_loadso
  SDL_locale
  SDL_log
  SDL_main
  SDL_messagebox
  SDL_metal
  SDL_misc
  SDL_mouse
  SDL_mutex
  SDL_notification
  SDL_pen
  SDL_pixels
  SDL_platform
  SDL_power
  SDL_process
  SDL_properties
  SDL_rect
  SDL_render
  SDL_revision
  SDL_scancode
  SDL_sensor
  SDL_stdinc
  SDL_storage
  SDL_surface
  SDL_system
  SDL_thread
  SDL_time
  SDL_timer
  SDL_tray
  SDL_touch
  SDL_version
  SDL_video
  SDL_vulkan
)


# Generate
for file in "${FILES[@]}"; do
  
  ARGS=(
    -p SDL_
    -m SDL
    -l SDL3
    -n Engine.SDL3
    -c file=single
    
    --remap char=byte
    --remap Sint64=long
    --remap Uint64=ulong
    --remap bool=SDL_Bool

    --generate macro-bindings
    --generate fnptr-codegen=false
    --generate funcs-with-body=false
    
    --with-access-specifier *=internal
    
    --exclude SDL_FUNCTION
    --exclude SDL_memcpy
    --exclude SDL_memmove
    --exclude SDL_memset
    
    --additional=-U_WIN32
    --additional=-Ulinux
    --additional=-U__linux
    --additional=-U__linux__
    --additional=-Uunix
    --additional=-U__unix
    --additional=-U__unix__
    --additional=-U__APPLE__
  )
    
  echo "Generating $file.h"
  ClangSharpPInvokeGenerator.cmd "${ARGS[@]}" -I "$BASEPATH/SDL/include" -f "$BASEPATH/SDL/include/SDL3/$file.h" -o "$OUTPUTS/$file.cs" || true
  
done


# Post process (order matters)
find "$OUTPUTS" -type f -name "*.cs" -print0 | while IFS= read -r -d '' file; do
  
  # Hints & Properties
  sed -i -E 's/public static ReadOnlySpan<byte> ([A-Za-z0-9_]+) => "([^"]*)"u8;/public static string \1 => "\2";/' "$file"

  # Remove Attributes
  sed -i -E '/\[return: NativeTypeName\("[^"]*"\)\]/d' "$file"
  sed -i -E 's/\[NativeTypeName\("[^"]*"\)\] //g' "$file"
  sed -i -E '/\[NativeTypeName.*\]/d' "$file"

  # Remove Argslist
  sed -i -E 's/\, __arglist//g' "$file"
  
  # Rebuild Methods
  sed -i -E 's/public static extern/private static extern/g' "$file"
  sed -E -i 's/(static extern [^ ]+ )([A-Za-z_][A-Za-z0-9_]*)\(/\1iSDL_\2(/g' "$file"
  
done
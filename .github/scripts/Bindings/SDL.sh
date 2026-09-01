#!/usr/bin/env bash
set +e

BASEPATH="$(cd "$WORKSPACE" && pwd)"

git clone --recurse-submodules https://github.com/libsdl-org/SDL.git "$BASEPATH/SDL"

OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

ClangSharpPInvokeGenerator.cmd \
-f $BASEPATH/SDL/include/SDL3/SDL.h \
-f $BASEPATH/SDL/include/SDL3/SDL_stdinc.h \
-f $BASEPATH/SDL/include/SDL3/SDL_assert.h \
-f $BASEPATH/SDL/include/SDL3/SDL_asyncio.h \
-f $BASEPATH/SDL/include/SDL3/SDL_atomic.h \
-f $BASEPATH/SDL/include/SDL3/SDL_endian.h \
-f $BASEPATH/SDL/include/SDL3/SDL_error.h \
-f $BASEPATH/SDL/include/SDL3/SDL_properties.h \
-f $BASEPATH/SDL/include/SDL3/SDL_thread.h \
-f $BASEPATH/SDL/include/SDL3/SDL_mutex.h \
-f $BASEPATH/SDL/include/SDL3/SDL_iostream.h \
-f $BASEPATH/SDL/include/SDL3/SDL_audio.h \
-f $BASEPATH/SDL/include/SDL3/SDL_bits.h \
-f $BASEPATH/SDL/include/SDL3/SDL_blendmode.h \
-f $BASEPATH/SDL/include/SDL3/SDL_pixels.h \
-f $BASEPATH/SDL/include/SDL3/SDL_rect.h \
-f $BASEPATH/SDL/include/SDL3/SDL_surface.h \
-f $BASEPATH/SDL/include/SDL3/SDL_camera.h \
-f $BASEPATH/SDL/include/SDL3/SDL_clipboard.h \
-f $BASEPATH/SDL/include/SDL3/SDL_cpuinfo.h \
-f $BASEPATH/SDL/include/SDL3/SDL_video.h \
-f $BASEPATH/SDL/include/SDL3/SDL_dialog.h \
-f $BASEPATH/SDL/include/SDL3/SDL_guid.h \
-f $BASEPATH/SDL/include/SDL3/SDL_power.h \
-f $BASEPATH/SDL/include/SDL3/SDL_sensor.h \
-f $BASEPATH/SDL/include/SDL3/SDL_joystick.h \
-f $BASEPATH/SDL/include/SDL3/SDL_gamepad.h \
-f $BASEPATH/SDL/include/SDL3/SDL_scancode.h \
-f $BASEPATH/SDL/include/SDL3/SDL_keycode.h \
-f $BASEPATH/SDL/include/SDL3/SDL_keyboard.h \
-f $BASEPATH/SDL/include/SDL3/SDL_mouse.h \
-f $BASEPATH/SDL/include/SDL3/SDL_touch.h \
-f $BASEPATH/SDL/include/SDL3/SDL_pen.h \
-f $BASEPATH/SDL/include/SDL3/SDL_events.h \
-f $BASEPATH/SDL/include/SDL3/SDL_filesystem.h \
-f $BASEPATH/SDL/include/SDL3/SDL_gpu.h \
-f $BASEPATH/SDL/include/SDL3/SDL_haptic.h \
-f $BASEPATH/SDL/include/SDL3/SDL_hidapi.h \
-f $BASEPATH/SDL/include/SDL3/SDL_hints.h \
-f $BASEPATH/SDL/include/SDL3/SDL_init.h \
-f $BASEPATH/SDL/include/SDL3/SDL_loadso.h \
-f $BASEPATH/SDL/include/SDL3/SDL_locale.h \
-f $BASEPATH/SDL/include/SDL3/SDL_log.h \
-f $BASEPATH/SDL/include/SDL3/SDL_messagebox.h \
-f $BASEPATH/SDL/include/SDL3/SDL_metal.h \
-f $BASEPATH/SDL/include/SDL3/SDL_misc.h \
-f $BASEPATH/SDL/include/SDL3/SDL_platform.h \
-f $BASEPATH/SDL/include/SDL3/SDL_process.h \
-f $BASEPATH/SDL/include/SDL3/SDL_render.h \
-f $BASEPATH/SDL/include/SDL3/SDL_storage.h \
-f $BASEPATH/SDL/include/SDL3/SDL_system.h \
-f $BASEPATH/SDL/include/SDL3/SDL_time.h \
-f $BASEPATH/SDL/include/SDL3/SDL_timer.h \
-f $BASEPATH/SDL/include/SDL3/SDL_tray.h \
-f $BASEPATH/SDL/include/SDL3/SDL_version.h \
-f $BASEPATH/SDL/include/SDL3/SDL_main.h \
-I $BASEPATH/SDL/include \
-n Monolith.SDL3 \
-m SDL \
-l SDL3 \
-c file=multi \
-o "$OUTPUTS" \
--with-access-specifier *=internal \
--generate funcs-with-body=false \
--generate helper-types

echo "Output files...."
find "$OUTPUTS"
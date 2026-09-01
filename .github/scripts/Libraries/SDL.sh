#!/usr/bin/env bash
set +e

BASEPATH="$(pwd)"

if [[ ! -d "$BASEPATH/SDL" ]]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL.git "$BASEPATH/SDL"
fi

# Environment
INSTALLPATH="$BASEPATH/SDL/install_output"
BUILDPATH="$BASEPATH/SDL/build_ouput"
mkdir -p "$BUILDPATH"
mkdir -p "$INSTALLPATH"
cd "$BUILDPATH"

# SDL
cmake .. \
  "${ARGS[@]}" \
  -DSDL_INSTALL=ON \
  -DSDL_TEST_LIBRARY=OFF \
  -DCMAKE_BUILD_TYPE=Release \
  -DCMAKE_POLICY_VERSION_MINIMUM=3.5 \
  -DCMAKE_INSTALL_PREFIX="$INSTALLPATH"

cmake --build . --config Release
cmake --install . --config Release

echo "Output files...."
find "$INSTALLPATH"
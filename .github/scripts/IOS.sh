#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Setup
if [[ "$RID" == "iossimulator-"* ]]; then
  SDK="iphonesimulator"
else
  SDK="iphoneos"
fi

# SDL
ARGS=( -G "Ninja" -DSDL_SHARED=OFF -DSDL_STATIC=ON -DCMAKE_SYSTEM_NAME=iOS -DCMAKE_OSX_SYSROOT=$SDK -DCMAKE_OSX_ARCHITECTURES=$CPU -DCMAKE_OSX_DEPLOYMENT_TARGET=13.0 )
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.so" "$OUTPUTS"
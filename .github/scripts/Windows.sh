#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# SDL
ARGS=( -G "Visual Studio 17 2022" -DSDL_SHARED=ON -DSDL_STATIC=OFF )
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/bin/SDL3.dll" "$OUTPUTS"
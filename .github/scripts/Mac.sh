#!/usr/bin/env bash
set -e

# Environment
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Options
GENERATOR="Ninja"

# SDL
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.dylib" "$OUTPUTS"
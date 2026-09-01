#!/usr/bin/env bash
set -e

# ENVIRONMENT
BASEPATH="$(cd "$WORKSPACE" && pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Setup
export GENERATOR="Ninja"

# SDL
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.dylib" "$OUTPUTS"

echo "Output files:"
ls -la "$INSTALLPATH/lib/"
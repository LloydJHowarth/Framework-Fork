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
cp "$INSTALLPATH/lib/libSDL3.so" "$OUTPUTS"

# SDL JAR
source "$BASEPATH/.github/scripts/Libraries/SDLActivity.sh"
cp "$INSTALLPATH/SDLActivity.jar" "$OUTPUTS"
#!/usr/bin/env bash
set -e

# ENVIRONMENT
BASEPATH="$(pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Options
GENERATOR="Visual Studio 17 2022"

# SDL
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/bin/SDL3.dll" "$OUTPUTS"
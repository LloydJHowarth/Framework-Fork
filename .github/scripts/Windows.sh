#!/usr/bin/env bash
set -e

# ENVIRONMENT
BASEPATH="$(cd "$WORKSPACE" && pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Setup
export GENERATOR="Visual Studio 17 2022"

# SDL
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/bin/SDL3.dll" "$OUTPUTS"

echo "Output files:"
ls -la "$INSTALLPATH/lib/"
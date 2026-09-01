#!/usr/bin/env bash
set -e

# ENVIRONMENT
BASEPATH="$(cd "$WORKSPACE" && pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

# Setup
export GENERATOR="Ninja"

# Packages
sudo apt-get update
sudo apt-get install -y \
  build-essential git make pkg-config cmake ninja-build \
  libx11-dev libxext-dev libxrandr-dev libxcursor-dev libxi-dev libxinerama-dev \
  libxfixes-dev libxss-dev libxtst-dev libxkbcommon-dev libdrm-dev libgbm-dev \
  libgl1-mesa-dev libgles2-mesa-dev libegl1-mesa-dev \
  libasound2-dev libpulse-dev libaudio-dev libfribidi-dev libjack-dev libsndio-dev \
  libdbus-1-dev libibus-1.0-dev libudev-dev libpipewire-0.3-dev libwayland-dev \
  libdecor-0-dev liburing-dev

# SDL
source "$BASEPATH/.github/scripts/Libraries/SDL.sh"
cp "$INSTALLPATH/lib/libSDL3.so" "$OUTPUTS"

echo "Output files:"
ls -la "$INSTALLPATH/lib/"
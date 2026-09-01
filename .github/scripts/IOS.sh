#!/usr/bin/env bash
set -e

# ENVIRONMENT
BASEPATH="$(cd "$WORKSPACE" && pwd)"
OUTPUTS="$BASEPATH/outputs"
mkdir -p "$OUTPUTS"

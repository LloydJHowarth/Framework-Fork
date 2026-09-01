#!/usr/bin/env bash
set +e

# SDL
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

# Activity
cd "$BASEPATH/SDL/android-project/app/src/main/java" && mkdir -p out
JAVA_FILES=$(find . -name "*.java")
javac -source 1.8 -target 1.8 -classpath "$ANDROID_HOME/platforms/android-$ANDROID_COMPILE/android.jar" -d out $JAVA_FILES
jar cf SDLActivity.jar -C out .
jar tf SDLActivity.jar

cp SDLActivity.jar "$INSTALLPATH/SDLActivity.jar"

echo "Output files...."
find "$INSTALLPATH"
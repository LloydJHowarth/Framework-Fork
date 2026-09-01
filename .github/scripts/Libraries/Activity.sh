#!/usr/bin/env bash
set +e

BASEPATH="$(pwd)"

if [[ ! -d "$BASEPATH/SDL" ]]; then
    git clone --recurse-submodules https://github.com/libsdl-org/SDL.git "$BASEPATH/SDL"
fi

# Environemnt
INSTALLPATH="$BASEPATH/SDL/install_output"
BUILDPATH="$BASEPATH/SDL/build_ouput"
mkdir -p "$BUILDPATH"
mkdir -p "$INSTALLPATH"
cd "$BUILDPATH"

# Requirements
ANDROID_TARGET="21"
ANDROID_COMPILE="36"
NDK_VERSION="29.0.13846066"
ANDROID_SDK="$ANDROID_HOME"
ANDROID_NDK="$ANDROID_NDK_HOME/build/cmake/android.toolchain.cmake"
export PATH="$ANDROID_HOME/cmdline-tools/latest/bin:$ANDROID_HOME/tools/bin:$JAVA_HOME/bin:$PATH"
yes | sdkmanager --install "platforms;android-$ANDROID_TARGET"
yes | sdkmanager --install "platforms;android-$ANDROID_COMPILE"
yes | sdkmanager --install "ndk;$NDK_VERSION"
yes | sdkmanager --install "platform-tools"

# Activity
ANDROID_JAR="$ANDROID_HOME/platforms/android-$ANDROID_COMPILE/android.jar"
cd "$BASEPATH/SDL/android-project/app/src/main/java" || exit 1
mkdir -p out

JAVA_FILES=$(find . -name "*.java")
javac -source 1.8 -target 1.8 -classpath "$ANDROID_JAR" -d out $JAVA_FILES
jar cf SDLActivity.jar -C out .
jar tf SDLActivity.jar

cp SDLActivity.jar "$INSTALLPATH/SDLActivity.jar"

echo "Output files...."
find "$INSTALLPATH"
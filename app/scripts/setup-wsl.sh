#!/bin/bash

# Check if Node.js is installed
if ! command -v node &> /dev/null
then
    echo "Node.js not found, installing Node.js 20.18.0..."
    sudo apt update
    sudo apt install -y curl

    # Install Node.js 20.18.0 using n (Node version manager)
    curl -L https://raw.githubusercontent.com/tj/n/master/bin/n -o n
    bash n 20.18.0
    rm n

    # Verify Node.js installation
    node -v
else
    echo "Node.js is already installed, skipping installation."
fi

# Check if Java is installed
if ! command -v java &> /dev/null || [[ "$(java -version 2>&1)" != *"17."* ]]
then
    echo "Java 17 not found, installing OpenJDK 17..."
    sudo apt update
    sudo apt install -y openjdk-17-jdk-headless
else
    echo "Java 17 is already installed, skipping installation."
fi

# Set JAVA_HOME permanently in ~/.bashrc if not set
if ! grep -q "JAVA_HOME=/usr/lib/jvm/java-17-openjdk-amd64" ~/.bashrc; then
    echo 'export JAVA_HOME=/usr/lib/jvm/java-17-openjdk-amd64' >> ~/.bashrc
    export JAVA_HOME=/usr/lib/jvm/java-17-openjdk-amd64
    echo "JAVA_HOME set to /usr/lib/jvm/java-17-openjdk-amd64"
else
    echo "JAVA_HOME is already set, skipping."
fi

# Check if Android SDK command-line tools are installed
if [ ! -d "$HOME/android/cmdline-tools/latest" ]; then
    echo "Android SDK command-line tools not found, installing..."

    # Download the command-line tools for Android
    cd ~
    curl -o /tmp/cmd-tools.zip https://dl.google.com/android/repository/commandlinetools-linux-8512546_latest.zip

    # Create directories and unzip the tools
    mkdir -p android/cmdline-tools
    unzip -q /tmp/cmd-tools.zip -d android/cmdline-tools
    mv android/cmdline-tools/cmdline-tools android/cmdline-tools/latest

    # Clean up the downloaded zip file
    rm /tmp/cmd-tools.zip

    echo "Android SDK command-line tools installed successfully."
else
    echo "Android SDK command-line tools are already installed, skipping."
fi

# Set ANDROID_HOME and ANDROID_SDK_ROOT permanently in ~/.bashrc if not set
if ! grep -q "ANDROID_HOME=\$HOME/android" ~/.bashrc; then
    echo 'export ANDROID_HOME=$HOME/android' >> ~/.bashrc
    export ANDROID_HOME=$HOME/android
    echo "ANDROID_HOME set to $HOME/android"
else
    echo "ANDROID_HOME is already set, skipping."
fi

if ! grep -q "ANDROID_SDK_ROOT=\${ANDROID_HOME}" ~/.bashrc; then
    echo 'export ANDROID_SDK_ROOT=${ANDROID_HOME}' >> ~/.bashrc
    export ANDROID_SDK_ROOT=${ANDROID_HOME}
    echo "ANDROID_SDK_ROOT set to \${ANDROID_HOME}"
else
    echo "ANDROID_SDK_ROOT is already set, skipping."
fi

# Update PATH to include Android SDK tools if not set
if ! grep -q 'PATH=\$ANDROID_HOME/cmdline-tools/latest/bin:\$ANDROID_HOME/platform-tools:\$ANDROID_HOME/tools:\$ANDROID_HOME/tools/bin:\$PATH' ~/.bashrc; then
    echo 'export PATH=$ANDROID_HOME/cmdline-tools/latest/bin:$ANDROID_HOME/platform-tools:$ANDROID_HOME/tools:$ANDROID_HOME/tools/bin:$PATH' >> ~/.bashrc
    export PATH=$ANDROID_HOME/cmdline-tools/latest/bin:$ANDROID_HOME/platform-tools:$ANDROID_HOME/tools:$ANDROID_HOME/tools/bin:$PATH
    echo "PATH updated with Android SDK tools"
else
    echo "PATH already contains Android SDK tools, skipping."
fi

# Accept Android SDK licenses and update the SDK
yes | sdkmanager --licenses

# Check if required Android SDK packages are installed
INSTALLED_PACKAGES=$(sdkmanager --list | grep -Eo 'platforms;android-[0-9]+|build-tools;[0-9]+\.[0-9]+\.[0-9]+')

REQUIRED_PLATFORMS="platforms;android-34"
REQUIRED_BUILD_TOOLS="build-tools;34.0.0"

if [[ "$INSTALLED_PACKAGES" != *"$REQUIRED_PLATFORMS"* ]]; then
    echo "Installing Android platform 34..."
    sdkmanager "$REQUIRED_PLATFORMS"
else
    echo "Android platform 34 is already installed, skipping."
fi

if [[ "$INSTALLED_PACKAGES" != *"$REQUIRED_BUILD_TOOLS"* ]]; then
    echo "Installing Android build-tools 34.0.0..."
    sdkmanager "$REQUIRED_BUILD_TOOLS"
else
    echo "Android build-tools 34.0.0 are already installed, skipping."
fi

# Update the SDK
sdkmanager --update

echo "Setup complete, restart WSL"

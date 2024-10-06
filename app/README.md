# TravelBuddy Application

## Get started

1. Install dependencies

```bash
npm install
```

2. Start the app

```bash
npm start
```

The app will start in Expo Go environment, that has some limitations when working directly with native code.

## Development workflow

During development you have 2 options to debug the app:

1. Using Expo Go environment

This should be sufficient while sticking to Expo-supported packages. To run app in Expo Go environment simply run

```bash
npm start
```

or to run it directly on Android device/emulator

```bash
npm run android
```

2. Using development build

If you need to use packages that are not supported by Expo, or if you want to run app in development mode that is closer (in terms of performance and functionality) to production build you need to create a development build

```bash
npm run build:dev
```

After that install the _.apk_ build on device/emulator and run

```bash
npm run android:dev
```

## Preview and production builds

Preview and production builds don't include developer tools. The preview build is available as _.apk_ so it is easier to install. Production build is a _.aab_ that can be deployed to Google Play.

To create preview build run

```bash
npm run build:prev
```

To create production build run

```bash
npm run build:prod
```

## Build process requirements

1. Build scripts work on Linux and macOS. To run them on Windows use WSL.
2. Build scripts require JDK, Node and some Android related build tools. To make the setup easier, you can use the _setup-wsl.sh_ script.
3. You need eas CLI tool.
4. You need to login to Expo with eas CLI tool.

## ESLint and Pretter

This project uses ESLint and Prettier to maintain high code quality and automatic formatting

### Running ESLint

To run ESLint and check for errors in your code, use the following command:

```bash
npm run lint
```

This command will analyze the entire codebase and display any errors or warnings in the console.

### Running Prettier

To format your code according to Prettier's rules, use the following command:

```bash
npm run prettier
```

This command will format all the files in the project based on the Prettier configuration.

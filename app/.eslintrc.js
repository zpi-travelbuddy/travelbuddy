/*eslint no-undef: "error"*/

module.exports = {
  env: {
    es2021: true,
    node: true,
  },
  globals: {
    module: "readonly",
  },
  parser: "@typescript-eslint/parser",
  extends: [
    "eslint:recommended",
    "plugin:react/recommended",
    "plugin:@typescript-eslint/recommended",
    "plugin:prettier/recommended",
    "plugin:react-native/all",
    "plugin:react/jsx-runtime",
  ],
  files: ["**/*.{js,jsx,mjs,cjs,ts,tsx}"],
  parserOptions: {
    ecmaVersion: 2020,
    sourceType: "module",
    ecmaFeatures: {
      jsx: true,
    },
  },
  plugins: ["react", "react-native"],
  rules: {
    "react/react-in-jsx-scope": "off",
    "no-unused-vars": "warn",
    "prettier/prettier": "error",
    "react/jsx-uses-react": "off",
    "react/no-unescaped-entities": "off",
    "@typescript-eslint/no-require-imports": "off",
    "no-use-before-define": "off",
  },
  settings: {
    react: {
      version: "detect",
    },
  },
  ignores: [
    "node_modules/",
    "dist/",
    ".eslintrc.js",
    ".expo/",
    "npm-debug.*",
    "*.jks",
    "*.p8",
    "*.p12",
    "*.key",
    "*.mobileprovision",
    "*.orig.*",
    "web-build/",
  ],
};

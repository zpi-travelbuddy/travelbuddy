import globals from "globals";
import pluginJs from "@eslint/js";
import tseslint from "typescript-eslint";
import pluginReact from "eslint-plugin-react";
import eslintPluginPrettierRecommended from "eslint-plugin-prettier/recommended";

export default [
  {
    files: ["**/*.js", "**/*.mjs"],
    ignores: ["**/*.test.js"],
    languageOptions: {
      ecmaVersion: 2022,
      sourceType: "module",
      globals: {
        ...globals.browser,
        ...globals.node,
      },
    },
  },
  { files: ["**/*.{js,mjs,cjs,ts,jsx,tsx}"] },
  { languageOptions: { globals: globals.browser } },
  { settings: { react: { version: "detect" } } },
  pluginJs.configs.recommended,
  ...tseslint.configs.recommended,
  pluginReact.configs.flat.recommended,
  eslintPluginPrettierRecommended,
  {
    rules: {
      "react/react-in-jsx-scope": "off",
      "@typescript-eslint/no-unused-vars": "warn",
      "prettier/prettier": "error",
      "react/jsx-uses-react": "off",
      "react/no-unescaped-entities": "off",
      "@typescript-eslint/no-require-imports": "off",
      "no-use-before-define": [
        "warn",
        {
          functions: true,
          classes: true,
          variables: false,
          allowNamedExports: true,
        },
      ],
    },
  },
];

export const amplifyConfig = {
  Auth: {
    region: process.env.EXPO_PUBLIC_COGNITO_REGION,
    userPoolId: process.env.EXPO_PUBLIC_COGNITO_USER_POOL_ID,
    userPoolWebClientId: process.env.EXPO_PUBLIC_COGNITO_CLIENT_ID,
    signUpVerificationMethod: "code",
  },
};

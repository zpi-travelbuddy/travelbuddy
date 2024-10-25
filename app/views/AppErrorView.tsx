import { StyleSheet, Text, View, Image, Dimensions } from "react-native";
import React from "react";
import { Button, MD3Theme, Title, useTheme } from "react-native-paper";

const { height, width } = Dimensions.get("window");

const AppErrorView = () => {
  const theme = useTheme();
  const styles = createStyles(theme);

  const imageSource = theme.dark
    ? require("@/assets/images/ErrorView-dark.png")
    : require("@/assets/images/ErrorView-light.png");

  return (
    <View style={styles.container}>
      <View style={styles.content}>
        <Image source={imageSource} style={styles.image} />
        <Title style={styles.title}>Nie znaleziono strony!</Title>
        <Text style={styles.text}>Napotkaliśmy pewne problemy.</Text>
        <Text style={styles.text}>
          Kliknij poniżej, aby wrócić do wycieczek.
        </Text>
      </View>
      <Button
        mode="contained"
        style={styles.backButton}
        icon="arrow-left"
        onPress={() => console.log("Powrót")}
      >
        Powrót
      </Button>
    </View>
  );
};

export default AppErrorView;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    container: {
      flex: 1,
      alignItems: "center",
      justifyContent: "center",
      backgroundColor: theme.colors.surface,
    },
    content: {
      flex: 1,
      width: "100%",
      alignItems: "center",
      paddingTop: height * 0.05,
    },
    image: {
      width: "100%",
      height: height * 0.5,
      bottom: height * 0.1,
    },
    title: {
      ...theme.fonts.displaySmall,
      fontWeight: "bold",
    },
    text: {
      ...theme.fonts.bodyLarge,
      color: theme.colors.onSurface,
      textAlign: "center",
    },
    backButton: {
      marginVertical: 50,
      width: "50%",
      alignContent: "center",
    },
  });

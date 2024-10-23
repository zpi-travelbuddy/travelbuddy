import { StyleSheet, Text, View } from "react-native";
import React from "react";

const SettingsView = () => {
  return (
    <View style={styles.container}>
      <Text>SettingsView</Text>
    </View>
  );
};

export default SettingsView;

const styles = StyleSheet.create({
  container: {
    flex: 1,
    alignItems: "center",
  },
});

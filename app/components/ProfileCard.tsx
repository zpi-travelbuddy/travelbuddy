import { StyleSheet, Text, TouchableOpacity, View } from "react-native";
import React from "react";
import Icon from "react-native-vector-icons/MaterialIcons";
import { PROFILE_ICON } from "@/constants/Icons";
import { MD3ThemeExtended } from "@/constants/Themes";
import { useTheme } from "react-native-paper";

interface ProfileCardProps {
  text: string;
  showStar?: boolean;
  onPress?: () => void;
}

const ProfileCard: React.FC<ProfileCardProps> = ({
  text,
  showStar = false,
  onPress,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  return (
    <TouchableOpacity style={styles.container} onPress={onPress}>
      <Icon
        name={PROFILE_ICON}
        size={32}
        color={theme.colors.onSurfaceVariant}
        style={styles.icon}
      />

      <Text style={styles.text}>{text}</Text>

      {showStar && (
        <Icon
          name="star"
          size={28}
          color={theme.colors.onSurfaceVariant}
          style={styles.star}
        />
      )}
    </TouchableOpacity>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    container: {
      flexDirection: "row",
      alignItems: "center",
      width: "90%",
      alignSelf: "center",
      padding: 10,
      marginVertical: 10,
      height: 60,
      borderRadius: 20,
      backgroundColor: theme.colors.surfaceContainerHighest,
    },
    icon: {
      marginRight: 20,
    },
    text: {
      ...theme.fonts.bodyLarge,
      flex: 1,
      color: theme.colors.onSurface,
    },
    star: {
      marginLeft: 10,
    },
  });

export default ProfileCard;

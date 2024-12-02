import React, { useRef, useEffect, useCallback, useState } from "react";
import { View, Text, StyleSheet, TouchableWithoutFeedback } from "react-native";
import { MD3Theme, TextInput, useTheme } from "react-native-paper";
import BottomSheet, { BottomSheetView } from "@gorhom/bottom-sheet";
import Animated, {
  useAnimatedKeyboard,
  useAnimatedStyle,
} from "react-native-reanimated";
import ActionButtons from "./ActionButtons";
import { useRouter } from "expo-router";
import {
  API_CATEGORY_PROFILES,
  API_CONDITION_PROFILES,
} from "@/constants/Endpoints";
import { ProfileRequest, ProfileDetails, ProfileType } from "@/types/Profile";
import { useAuth } from "@/app/ctx";
import { useSnackbar } from "@/context/SnackbarContext";

const REQUIRED_PROFILE_NAME_MESSAGE = "The name field is required.";

const DUPLICATE_PROFILE_NAME_MESSAGE =
  "profile with the same name already exists.";

interface BottomSheetComponentProps {
  isVisible: boolean;
  onClose: () => void;
  label?: string;
  profileType: ProfileType;
}

const CreatingProfileBottonSheet: React.FC<BottomSheetComponentProps> = ({
  isVisible,
  onClose,
  label,
  profileType,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme);
  const sheetRef = useRef<BottomSheet>(null);

  const [profileName, setProfileName] = useState<string>("");
  const [loading, setLoading] = useState<boolean>(false);
  const [error, setError] = useState<string>("");

  const keyboard = useAnimatedKeyboard();
  const router = useRouter();
  const { api } = useAuth();
  const { showSnackbar } = useSnackbar();

  const handleAnimate = useCallback(
    (fromIndex: number, toIndex: number) => {
      if (toIndex === -1) onClose();
    },
    [onClose],
  );

  const handleCreateProfileError = (err: any) => {
    if (err.response.data.endsWith(DUPLICATE_PROFILE_NAME_MESSAGE)) {
      return "Istnieje już profil z tą nazwą!";
    } else if (err.response.data.endsWith(REQUIRED_PROFILE_NAME_MESSAGE)) {
      return "Nazwa profilu jest wymagana!";
    } else
      return (
        "Błąd podczas zapisywania profilu: " + JSON.stringify(err.response.data)
      );
  };

  const handleCreateProfile = async (
    request: ProfileRequest,
    onSuccess?: (profile: ProfileDetails) => void,
  ): Promise<void> => {
    try {
      setLoading(true);
      setError("");
      const endpoint =
        profileType === "Category"
          ? API_CATEGORY_PROFILES
          : API_CONDITION_PROFILES;

      const response = await api!.post<ProfileDetails>(endpoint, request);

      if (!response) {
        showSnackbar("Nie udało się stworzyć profilu.");
        return;
      }

      const newProfile = response.data;
      showSnackbar("Profil został utworzony!");
      setError("");
      if (onSuccess) onSuccess(newProfile);
    } catch (err: any) {
      setError(handleCreateProfileError(err));
    } finally {
      setLoading(false);
    }
  };

  const handleSave = useCallback(
    async (name: string) => {
      await handleCreateProfile(
        {
          profileType: profileType,
          name: name,
          categoryIds: [],
          conditionIds: [],
        },
        (newProfile) => {
          if (!error) {
            const path =
              profileType === "Category"
                ? `/(auth)/(tabs)/settings/categoryProfiles/manage`
                : `/(auth)/(tabs)/settings/conditionProfiles/manage`;
            setError("");
            setProfileName("");
            onClose();
            router.push(`${path}/${newProfile.id}`);
          }
        },
      );
    },
    [handleCreateProfile, router, profileType, error],
  );

  useEffect(() => {
    if (isVisible) sheetRef.current?.snapToIndex(0);
    else sheetRef.current?.close();
  }, [isVisible]);

  const animatedStyles = useAnimatedStyle(() => {
    return {
      marginBottom: keyboard.height.value,
    };
  });

  return (
    <>
      <BottomSheet
        ref={sheetRef}
        index={isVisible ? 0 : -1}
        enablePanDownToClose
        onClose={onClose}
        onAnimate={handleAnimate}
        containerStyle={styles.containerStyle}
        backgroundComponent={({ style }) => (
          <View style={[style, styles.contentContainer]} />
        )}
      >
        <BottomSheetView>
          {!!label && <Text style={styles.label}>{label}</Text>}
          <Animated.View style={[animatedStyles, styles.contentContainer]}>
            <TextInput
              style={styles.input}
              mode="outlined"
              label="Nazwa profilu"
              value={profileName}
              onChangeText={setProfileName}
              error={!!error}
            />
            {!!error && <Text style={styles.textError}>{error}</Text>}
            <ActionButtons
              onAction1={onClose}
              action1ButtonLabel={"Anuluj"}
              onAction2={async () => await handleSave(profileName)}
              action2ButtonLabel={"Zapisz"}
              action1Icon={undefined}
              action2Icon={undefined}
            />
          </Animated.View>
        </BottomSheetView>
      </BottomSheet>

      {isVisible && (
        <TouchableWithoutFeedback onPress={onClose}>
          <View style={styles.scrim} />
        </TouchableWithoutFeedback>
      )}
    </>
  );
};

export default CreatingProfileBottonSheet;

const createStyles = (theme: MD3Theme) =>
  StyleSheet.create({
    contentContainer: {
      borderTopLeftRadius: 40,
      borderTopRightRadius: 40,
      backgroundColor: theme.colors.elevation.level1,
      justifyContent: "center",
      alignItems: "center",
    },
    input: {
      width: "80%",
      height: 50,
      marginTop: 10,
      backgroundColor: theme.colors.surface,
    },
    scrim: {
      ...StyleSheet.absoluteFillObject,
      backgroundColor: "rgba(0, 0, 0, 0.5)",
      zIndex: 1,
    },
    label: {
      ...theme.fonts.labelMedium,
      width: "80%",
      textAlign: "left",
      alignSelf: "center",
      color: theme.colors.onBackground,
      marginTop: 10,
    },
    containerStyle: { zIndex: 3 },
    textError: {
      marginTop: 10,
      color: theme.colors.error,
      width: "80%",
      textAlign: "left",
      ...theme.fonts.bodySmall,
    },
  });

import { MD3ThemeExtended } from "@/constants/Themes";
import React, { useState } from "react";
import { ScrollView, StyleSheet, Image, TouchableOpacity } from "react-native";
import { Modal, Portal, Button, Text, useTheme } from "react-native-paper";

interface ImagePickerPopupProps {
  images: Record<string, any>;
  visible: boolean;
  onClose: () => void;
  onSave: (selectedImage: string) => void;
}

const ImagePickerPopup: React.FC<ImagePickerPopupProps> = ({
  images,
  visible,
  onClose,
  onSave,
}) => {
  const theme = useTheme();
  const styles = createStyles(theme as MD3ThemeExtended);

  const [selectedImage, setSelectedImage] = useState<string | null>(null);

  const handleImageSelect = (image: string) => {
    setSelectedImage(image);
  };

  const handleSave = () => {
    if (selectedImage) {
      onSave(selectedImage);
    }
    onClose();
  };

  return (
    <Portal>
      <Modal
        visible={visible}
        onDismiss={onClose}
        contentContainerStyle={styles.modalContainer}
      >
        <Text style={styles.title}>Wybierz obrazek</Text>
        <ScrollView contentContainerStyle={styles.gridContainer}>
          {Object.entries(images).map(([name, source]) => (
            <TouchableOpacity
              key={name}
              onPress={() => handleImageSelect(name)}
              style={[
                styles.imageWrapper,
                selectedImage === name && styles.selectedImage,
              ]}
            >
              <Image source={source} style={styles.image} />
            </TouchableOpacity>
          ))}
        </ScrollView>
        <Button mode="contained" onPress={handleSave} style={styles.saveButton}>
          Zapisz
        </Button>
      </Modal>
    </Portal>
  );
};

const createStyles = (theme: MD3ThemeExtended) =>
  StyleSheet.create({
    modalContainer: {
      backgroundColor: "white",
      padding: 20,
      margin: 20,
      borderRadius: 10,
    },
    title: {
      fontSize: 21,
      marginBottom: 15,
      textAlign: "center",
    },
    gridContainer: {
      flexDirection: "row",
      flexWrap: "wrap",
      justifyContent: "center",
      gap: 10,
    },
    imageWrapper: {
      borderWidth: 2,
      borderColor: "transparent",
      margin: 5,
      borderRadius: 5,
    },
    selectedImage: {
      borderColor: theme.colors.primary,
    },
    image: {
      width: 100,
      height: 100,
      borderRadius: 5,
    },
    saveButton: {
      marginTop: 15,
      paddingHorizontal: 20,
      alignSelf: "center",
    },
  });

export default ImagePickerPopup;

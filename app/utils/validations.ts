import { FieldType } from "@/types/auth";

export const validateEmail = (email: string) => {
  const re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return re.test(email);
};

export const validateField = (field: FieldType, value: string) => {
  if (!value)
    return `${field === FieldType.EMAIL ? "Email jest wymagany" : "Hasło jest wymagane"}`;
  if (field === FieldType.EMAIL && !validateEmail(value))
    return "Niepoprawny format email";
  return "";
};

export const validateEmail = (email: string) => {
  const re = /\S+@\S+\.\S+/;
  return re.test(email);
};

export const validateField = (field: "email" | "password", value: string) => {
  if (!value)
    return `${field === "email" ? "Email jest wymagany" : "Hasło jest wymagane"}`;
  if (field === "email" && !validateEmail(value))
    return "Niepoprawny format email";
  return "";
};

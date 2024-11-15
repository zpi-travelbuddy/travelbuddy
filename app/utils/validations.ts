import { FieldType } from "@/types/auth";
import { DateRange, TripCreationErrors } from "@/types/Trip";

const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

const hasNumber = /\d/; // At least 1 number
const hasUppercase = /[A-Z]/; // At least 1 uppercase letter
const hasLowercase = /[a-z]/; // At least 1 lowercase letter
const hasSpecialChar = /[!@#$%^&*(),.?":{}|<>]/; // At least 1 special character

export const validateEmail = (email: string) => {
  if (!email) return "Email jest wymagany";
  if (!emailRegex.test(email)) return "Niepoprawny format email";
  return "";
};

export const validatePassword = (password: string) => {
  if (!password) return "Hasło jest wymagane";
  return "";
};

export const validateNewPassword = (password: string) => {
  if (!password) return "Hasło jest wymagane";
  if (password.length < 8) return "Hasło musi mieć co najmniej 8 znaków";
  if (!hasLowercase.test(password))
    return "Hasło musi zawierać co najmniej jedną małą literę";
  if (!hasUppercase.test(password))
    return "Hasło musi zawierać co najmniej jedną dużą literę";
  if (!hasNumber.test(password))
    return "Hasło musi zawierać co najmniej jedną cyfrę";
  if (!hasSpecialChar.test(password))
    return "Hasło musi zawierać co najmniej jeden znak specjalny";
  if (password.includes(" ")) return "Hasło nie może zawierać spacji";
  return "";
};

export const validateCode = (value: string) => {
  if (!value) return "Kod jest wymagany";
  return "";
};

export const validateTripForm = (
  tripName: string,
  range: DateRange,
  destinationId: string,
  numberOfPeople: string,
  budget: number | undefined,
): TripCreationErrors => {
  const newErrors: TripCreationErrors = {};
  if (!tripName) newErrors.tripName = "Wprowadź nazwę wycieczki";
  if (!range.startDate) newErrors.range = "Wybierz termin wycieczki";
  if (!destinationId) newErrors.destination = "Wybierz cel wycieczki";
  if (!numberOfPeople) newErrors.numberOfPeople = "Podaj liczbę osób";
  if (budget === undefined) newErrors.budget = "Podaj budżet";

  return newErrors;
};

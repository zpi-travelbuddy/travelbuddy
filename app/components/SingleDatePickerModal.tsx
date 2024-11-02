import { DatePickerModal } from "react-native-paper-dates";
import { CalendarDate } from "react-native-paper-dates/lib/typescript/Date/Calendar";
import { stringToDate } from "@/utils/TimeUtils";

interface SingleDatePickerModalProps {
  visible: boolean;
  startDate: string;
  endDate: string;
  onDismiss: () => void;
  onConfirm: ({ date }: { date: CalendarDate }) => void;
}

const SingleDatePickerModal = ({
  visible,
  startDate,
  endDate,
  onDismiss,
  onConfirm,
}: SingleDatePickerModalProps) => {
  // This is fix for the DatePicker incorrect validRange
  const fixedStartDate = stringToDate(startDate);
  const fixedEndDate = stringToDate(endDate);

  return (
    <DatePickerModal
      mode="single"
      visible={visible}
      date={fixedStartDate}
      onDismiss={onDismiss}
      onConfirm={onConfirm}
      validRange={{
        startDate: fixedStartDate,
        endDate: fixedEndDate,
      }}
      locale="pl"
      startWeekOnMonday={true}
    />
  );
};

export default SingleDatePickerModal;

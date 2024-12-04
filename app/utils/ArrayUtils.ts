export const conditionalItem = (condition: boolean, item: any) =>
  condition ? [item] : [];

export const invertRecord = (
  record: Record<string, string>,
): Record<string, string> => {
  const inverted: Record<string, string> = {};
  for (const [key, value] of Object.entries(record)) {
    inverted[value] = key;
  }
  return inverted;
};

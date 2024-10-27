export function formatMinutes(minutes: number): string {
  const hours = Math.floor(minutes / 60);

  if (hours > 0) {
    return `${hours} h ${minutes % 60} min`;
  }

  return `${minutes} min`;
}

export function formatTimeRange(startTime: string, endTime: string): string {
  return `${startTime} - ${endTime}`;
}

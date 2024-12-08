export const createLocationURL = (
  latitude: number,
  longitude: number,
  name: string,
): string => {
  const url = `https://www.google.com/maps?q=${latitude},${longitude} (${name})`;

  return url;
};

export const createNavigationURL = (
  fromLatitude: number,
  fromLongitude: number,
  toLatitude: number,
  toLongitude: number,
  travelMode: string,
): string => {
  const url = `https://www.google.com/maps/dir/?api=1&origin=${fromLatitude},${fromLongitude}&destination=${toLatitude},${toLongitude}&travelmode=${travelMode}`;

  return url;
};

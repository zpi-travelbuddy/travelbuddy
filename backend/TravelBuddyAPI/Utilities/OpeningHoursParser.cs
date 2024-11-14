using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.IdentityModel.Tokens;

namespace TravelBuddyAPI.Utilities
{
    public static partial class OpeningHoursParser
    {
        public static (TimeOnly opensAt, TimeOnly closesAt)? ParseOpeningHours(string? openingHours, DateOnly date)
        {
            if (string.IsNullOrEmpty(openingHours))
            {
                return null;
            }

            if (openingHours.Trim() == "24/7")
            {
                return (TimeOnly.MinValue, TimeOnly.MaxValue);
            }

            var rules = openingHours.Split([';', ','], StringSplitOptions.RemoveEmptyEntries);

            foreach (var rule in rules)
            {
                var dateRangeMatch = OpeningHoursRuleRegex().Match(rule.Trim());
                if (dateRangeMatch.Success)
                {
                    // Parse the date range parts
                    var startMonth = dateRangeMatch.Groups["startMonth"].Value;
                    var startDayStr = dateRangeMatch.Groups["startDay"].Value;
                    var endMonth = dateRangeMatch.Groups["endMonth"].Value;
                    var endDayStr = dateRangeMatch.Groups["endDay"].Value;

                    if (endMonth.IsNullOrEmpty())
                    {
                        endMonth = startMonth;
                    }

                    // Set start and end days
                    var startDay = string.IsNullOrEmpty(startDayStr) ? 1 : int.Parse(startDayStr);
                    var endDay = string.IsNullOrEmpty(endDayStr)
                        ? DateTime.DaysInMonth(date.Year, DateTime.ParseExact(endMonth, "MMM", CultureInfo.InvariantCulture).Month)
                        : int.Parse(endDayStr);

                    // Parse start and end dates
                    var startDate = ParseDate(date.Year, startMonth, startDay);
                    var endDate = ParseDate(date.Year, endMonth, endDay);

                    // Only proceed with this rule if date falls in the date range
                    if (IsDateInRangeIgnoringYear(date, startDate, endDate))
                    {
                        // Extract and validate the time range based on the day-of-week if present
                        var timeRange = ExtractTimeRangeForDay(rule.Trim(), date);
                        if (timeRange.HasValue)
                        {
                            return timeRange;
                        }
                    }
                }
                else
                {
                    // Handle standalone rules without specific date range
                    var timeRange = ExtractTimeRangeForDay(rule.Trim(), date);
                    if (timeRange.HasValue)
                    {
                        return timeRange;
                    }
                }
            }

            return null;
        }

        public static (TimeOnly opensAt, TimeOnly closesAt)? ExtractTimeRangeForDay(string rule, DateOnly date)
        {
            var dayOfWeekMap = new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Monday, "Mo" },
                { DayOfWeek.Tuesday, "Tu" },
                { DayOfWeek.Wednesday, "We" },
                { DayOfWeek.Thursday, "Th" },
                { DayOfWeek.Friday, "Fr" },
                { DayOfWeek.Saturday, "Sa" },
                { DayOfWeek.Sunday, "Su" }
            };
            var dayOfWeek = dayOfWeekMap[date.DayOfWeek];

            // Regex pattern to match optional day or day range with time range
            var dayRangePattern = @$"(?:(?<days>{dayOfWeek}|(?:Mo|Tu|We|Th|Fr|Sa|Su)(?:-(?:Mo|Tu|We|Th|Fr|Sa|Su))?)\s)?(?<opensAt>\d{{2}}:\d{{2}})-(?<closesAt>\d{{2}}:\d{{2}})";
            var dayRangeMatch = Regex.Match(rule, dayRangePattern);

            if (dayRangeMatch.Success)
            {
                var days = dayRangeMatch.Groups["days"].Value;
                var opensAt = TimeOnly.Parse(dayRangeMatch.Groups["opensAt"].Value);
                var closesAt = TimeOnly.Parse(dayRangeMatch.Groups["closesAt"].Value);

                // If days are specified, ensure the date's day of the week is within the specified range
                if (string.IsNullOrEmpty(days) || IsDayInRange(dayOfWeek, days))
                {
                    return (opensAt, closesAt);
                }
            }

            return null;
        }

        public static bool IsDayInRange(string dayOfWeek, string days)
        {
            if (days.Contains("-"))
            {
                var dayParts = days.Split('-');
                var startDay = dayParts[0];
                var endDay = dayParts[1];

                // Get day indices for range comparison
                var daysOfWeek = new[] { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
                var startIdx = Array.IndexOf(daysOfWeek, startDay);
                var endIdx = Array.IndexOf(daysOfWeek, endDay);
                var dayIdx = Array.IndexOf(daysOfWeek, dayOfWeek);

                return dayIdx >= startIdx && dayIdx <= endIdx;
            }

            // Single day case
            return dayOfWeek == days;
        }

        public static bool IsDateInRangeIgnoringYear(DateOnly testDate, DateOnly startDate, DateOnly endDate)
        {
            var start = new DateOnly(testDate.Year, startDate.Month, startDate.Day);
            var end = new DateOnly(testDate.Year, endDate.Month, endDate.Day);

            if (start <= end)
            {
                return testDate >= start && testDate <= end;
            }
            else
            {
                return testDate >= start || testDate <= end;
            }
        }

        public static DateOnly ParseDate(int year, string month, int day)
        {
            var monthNumber = DateTime.ParseExact(month, "MMM", CultureInfo.InvariantCulture).Month;
            return new DateOnly(year, monthNumber, day);
        }

        [GeneratedRegex(@"(?<startMonth>\w{3})(?: (?<startDay>\d{1,2}))?(?:-(?<endMonth>\w{3})(?: (?<endDay>\d{1,2}))?)?")]
        private static partial Regex OpeningHoursRuleRegex();
    }
}
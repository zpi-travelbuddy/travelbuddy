using System.Globalization;
using System.Text.RegularExpressions;

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
                var dateRangeMatch = OpeningHoursRuleRegex().Match(rule);
                if (dateRangeMatch.Success)
                {
                    var startDate = ParseDate(dateRangeMatch.Groups["startMonth"].Value, int.Parse(dateRangeMatch.Groups["startDay"].Value));
                    var endDate = ParseDate(dateRangeMatch.Groups["endMonth"].Value, int.Parse(dateRangeMatch.Groups["endDay"].Value));

                    if (IsDateInRangeIgnoringYear(date, startDate, endDate))
                    {
                        var timeRange = ExtractTimeRangeForDay(rule, date);
                        if (timeRange.HasValue)
                        {
                            return timeRange;
                        }
                    }
                }
                else
                {
                    var timeRange = ExtractTimeRangeForDay(rule, date);
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

            // Match for day range or single day with time range
            var dayRangePattern = @$"(?<days>{dayOfWeek}|(?:Mo|Tu|We|Th|Fr|Sa|Su)(?:-(?:Mo|Tu|We|Th|Fr|Sa|Su))?)\s(?<opensAt>\d{{2}}:\d{{2}})-(?<closesAt>\d{{2}}:\d{{2}})";
            var dayRangeMatch = Regex.Match(rule, dayRangePattern);

            if (dayRangeMatch.Success)
            {
                var days = dayRangeMatch.Groups["days"].Value;
                var opensAt = TimeOnly.Parse(dayRangeMatch.Groups["opensAt"].Value);
                var closesAt = TimeOnly.Parse(dayRangeMatch.Groups["closesAt"].Value);

                // Check if the date's day of the week is within the specified range
                if (IsDayInRange(dayOfWeek, days))
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

        public static bool IsDateInRangeIgnoringYear(DateOnly date, DateOnly startDate, DateOnly endDate)
        {
            var testDate = new DateOnly(1, date.Month, date.Day);
            var start = new DateOnly(1, startDate.Month, startDate.Day);
            var end = new DateOnly(1, endDate.Month, endDate.Day);

            if (start <= end)
            {
                return testDate >= start && testDate <= end;
            }
            else
            {
                return testDate >= start || testDate <= end;
            }
        }

        public static DateOnly ParseDate(string month, int day)
        {
            var monthNumber = DateTime.ParseExact(month, "MMM", CultureInfo.InvariantCulture).Month;
            return new DateOnly(1, monthNumber, day);
        }

        [GeneratedRegex(@"(?<startMonth>\w{3}) (?<startDay>\d{1,2})-(?<endMonth>\w{3}) (?<endDay>\d{1,2})")]
        private static partial Regex OpeningHoursRuleRegex();
    }
}
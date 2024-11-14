using System.Globalization;
using TravelBuddyAPI.Utilities;
using Xunit;

namespace TravelBuddyAPI.Tests.Utilities
{
    public class OpeningHoursParserTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ParseOpeningHours_NullOrEmptyInput_ShouldReturnNull(string openingHours)
        {
            var date = DateOnly.FromDateTime(DateTime.Now);
            var result = OpeningHoursParser.ParseOpeningHours(openingHours, date);
            Assert.Null(result);
        }

        [Fact]
        public void ParseOpeningHours_24_7_ShouldReturnMinMaxTimeOnly()
        {
            var date = DateOnly.FromDateTime(DateTime.Now);
            var result = OpeningHoursParser.ParseOpeningHours("24/7", date);
            Assert.NotNull(result);
            Assert.Equal(TimeOnly.MinValue, result?.opensAt);
            Assert.Equal(TimeOnly.MaxValue, result?.closesAt);
        }

        [Theory]
        [InlineData("Mo 09:00-17:00", "2023-10-02", "09:00", "17:00")] // Monday
        [InlineData("Tu 10:00-18:00", "2023-10-03", "10:00", "18:00")] // Tuesday
        public void ParseOpeningHours_SingleDay_ShouldReturnCorrectTimes(string openingHours, string dateStr, string expectedOpen, string expectedClose)
        {
            var date = DateOnly.Parse(dateStr);
            var result = OpeningHoursParser.ParseOpeningHours(openingHours, date);
            Assert.NotNull(result);
            Assert.Equal(TimeOnly.Parse(expectedOpen), result?.opensAt);
            Assert.Equal(TimeOnly.Parse(expectedClose), result?.closesAt);
        }

        [Theory]
        [InlineData("Mo-Fr 09:00-17:00", "2023-10-02", "09:00", "17:00")] // Monday
        [InlineData("Mo-Fr 09:00-17:00", "2023-10-06", "09:00", "17:00")] // Friday
        public void ParseOpeningHours_DayRange_ShouldReturnCorrectTimes(string openingHours, string dateStr, string expectedOpen, string expectedClose)
        {
            var date = DateOnly.Parse(dateStr);
            var result = OpeningHoursParser.ParseOpeningHours(openingHours, date);
            Assert.NotNull(result);
            Assert.Equal(TimeOnly.Parse(expectedOpen), result?.opensAt);
            Assert.Equal(TimeOnly.Parse(expectedClose), result?.closesAt);
        }

        [Theory]
        [InlineData("Jan 01-Jan 31 Mo-Fr 09:00-17:00", "2023-01-16", "09:00", "17:00")] // Within date range
        [InlineData("Dec 01-Jan 31 Mo-Fr 09:00-17:00", "2023-01-16", "09:00", "17:00")] // Within date range, year change
        [InlineData("Dec 01-Jan 31 Mo-Fr 09:00-17:00", "2023-01-15", null, null)] // Within date range, wrong day of week
        [InlineData("Jan 01-Jan 31 Mo-Fr 09:00-17:00", "2023-02-01", null, null)] // Outside date range
        [InlineData("Dec 01-Jan 31 Mo-Fr 09:00-17:00", "2023-02-01", null, null)] // Outside date range, year change
        [InlineData("Jan Mo-Fr 09:00-17:00", "2023-01-16", "09:00", "17:00")]
        [InlineData("Jan-Feb Mo-Fr 09:00-17:00", "2023-02-01", "09:00", "17:00")]
        [InlineData("Jan-Feb Mo-Fr 09:00-17:00", "2024-02-29", "09:00", "17:00")]
        [InlineData("Jan Mo-Fr 09:00-17:00", "2024-01-29", "09:00", "17:00")]
        [InlineData("Jan Mo-Fr 09:00-17:00", "2024-01-28", null, null)]
        [InlineData("Nov 01-Feb 15: 08:30-16:30; Feb 16-Mar 31: 08:30-17:00; Apr-Aug: 08:30-19:15; Sep: 08:30-19:00; Oct 08:30-18:30;", "2023-04-16", "08:30", "19:15")]
        [InlineData("Nov 01-Feb 15: 08:30-16:30; Feb 16-Mar 31: 08:30-17:00; Apr-Aug: 08:30-19:15; Sep: 08:30-19:00; Oct 08:30-18:30;", "2023-09-16", "08:30", "19:00")]
        public void ParseOpeningHours_DateRange_ShouldReturnCorrectTimes(string openingHours, string dateStr, string? expectedOpen, string? expectedClose)
        {
            var date = DateOnly.Parse(dateStr);
            var result = OpeningHoursParser.ParseOpeningHours(openingHours, date);
            if (expectedOpen == null || expectedClose == null)
            {
                Assert.Null(result);
            }
            else
            {
                Assert.NotNull(result);
                Assert.Equal(TimeOnly.Parse(expectedOpen), result?.opensAt);
                Assert.Equal(TimeOnly.Parse(expectedClose), result?.closesAt);
            }
        }

        [Theory]
        [InlineData("Mo 09:00-17:00", "2023-10-03")] // Tuesday
        [InlineData("Tu 10:00-18:00", "2023-10-02")] // Monday
        public void ParseOpeningHours_WrongDay_ShouldReturnNull(string openingHours, string dateStr)
        {
            var date = DateOnly.Parse(dateStr);
            var result = OpeningHoursParser.ParseOpeningHours(openingHours, date);
            Assert.Null(result);
        }
    }
}
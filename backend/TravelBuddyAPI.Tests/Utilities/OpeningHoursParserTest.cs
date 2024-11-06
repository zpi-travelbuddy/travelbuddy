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
        [InlineData("Jan 01-Jan 31 Mo-Fr 09:00-17:00", "2023-02-01", null, null)] // Outside date range
        [InlineData("Dec 01-Jan 31 Mo-Fr 09:00-17:00", "2023-02-01", null, null)] // Outside date range, year change
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
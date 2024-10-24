using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services
{
    public class NBPClientTest
    {
        NBPClient _nbpClient = new NBPClient();


        [Fact]
        public async Task GetRateAsync_ValidCurrencyCode_ReturnsRate()
        {
            // Arrange
            string currencyCode = "USD";
            var today = DateTime.Now;

            // Act
            if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
            {
                var exception = await Assert.ThrowsAsync<HttpRequestException>(() => _nbpClient.GetRateAsync(currencyCode));

                // Assert
                Assert.NotNull(exception);
                Assert.IsType<HttpRequestException>(exception);
            }
            else
            {
                var rate = await _nbpClient.GetRateAsync(currencyCode);

                // Assert
                Assert.NotNull(rate);
                Assert.True(rate > 0);
            }
        }

        [Fact]
        public async Task GetRateAsync_InvalidCurrencyCode_ThrowsHttpRequestException()
        {
            // Arrange
            string currencyCode = "INVALID";

            // Act & Assert
            await Assert.ThrowsAsync<HttpRequestException>(() => _nbpClient.GetRateAsync(currencyCode));
        }

        [Fact]
        public async Task GetCurrencyAsync_ReturnsCurrencyData()
        {
            // Act
            var currencyData = await _nbpClient.GetCurrencyAsync();

            // Assert
            Assert.NotNull(currencyData);
            Assert.Contains("table", currencyData);
        }

        [Fact]
        public async Task GetClosestRateAsync_ValidCurrencyCode_ReturnsRate()
        {
            // Arrange
            string currencyCode = "USD";
            DateOnly date = new DateOnly(2024, 10, 19);

            // Act
            var rate = await _nbpClient.GetClosestRateAsync(currencyCode, date);

            // Assert
            Assert.NotNull(rate);
            Assert.True(rate > 0);
        }

        [Fact]
        public async Task GetClosestRateAsync_InvalidCurrencyCode_ThrowsHttpRequestException()
        {
            // Arrange
            string currencyCode = "INVALID";
            DateOnly date = DateOnly.FromDateTime(DateTime.Now);

            // Act
            var exception = await Record.ExceptionAsync(() => _nbpClient.GetClosestRateAsync(currencyCode, date));

            // Assert
            Assert.NotNull(exception);
            Assert.IsType<HttpRequestException>(exception);
        }
    }
}
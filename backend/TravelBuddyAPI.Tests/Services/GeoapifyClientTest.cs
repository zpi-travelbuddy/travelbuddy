using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using TravelBuddyAPI.Models;
using TravelBuddyAPI.Services;
using Xunit;

namespace TravelBuddyAPI.Tests.Services
{
    public class GeoapifyClientTest
    {
        [Fact]
        public void ParseFeatureCollection_ShouldReturnEmptyList_WhenJsonResponseIsNull()
        {
            // Arrange
            dynamic jsonResponse = null;

            // Act
            var result = GeoapifyClient.ParseFeatureCollection(jsonResponse);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ParseFeatureCollection_ShouldReturnEmptyList_WhenFeaturesAreNull()
        {
            // Arrange
            dynamic jsonResponse = new JObject();
            jsonResponse.features = null;

            // Act
            var result = GeoapifyClient.ParseFeatureCollection(jsonResponse);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ParseFeatureCollection_ShouldReturnProviderPlaces_WhenValidJsonResponse()
        {
            // Arrange
            dynamic jsonResponse = JObject.Parse(@"{
                'features': [
                    {
                        'properties': {
                            'place_id': '123',
                            'name': 'Test Place',
                            'country': 'Test Country',
                            'city': 'Test City',
                            'street': 'Test Street',
                            'housenumber': '123',
                            'lat': 12.34,
                            'lon': 56.78,
                            'categories': ['category1', 'condition1']
                        }
                    }
                ]
            }");

            // Act
            List<ProviderPlace>? result = GeoapifyClient.ParseFeatureCollection(jsonResponse);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            var place = result[0];
            Assert.Equal("123", place.ProviderId);
            Assert.Equal("Test Place", place.Name);
            Assert.Equal("Test Country", place.Country);
            Assert.Equal("Test City", place.City);
            Assert.Equal("Test Street", place.Street);
            Assert.Equal("123", place.HouseNumber);
            Assert.Equal(12.34m, place.Latitude);
            Assert.Equal(56.78m, place.Longitude);
        }

        [Fact]
        public void ParseFeatureCollection_ShouldReturnProviderPlaces_WithCategoriesAndConditions()
        {
            // Arrange
            dynamic jsonResponse = JObject.Parse(@"{
                'features': [
                    {
                        'properties': {
                            'place_id': '123',
                            'name': 'Test Place',
                            'country': 'Test Country',
                            'city': 'Test City',
                            'street': 'Test Street',
                            'housenumber': '123',
                            'lat': 12.34,
                            'lon': 56.78,
                            'categories': ['category1.category2', 'condition1']
                        }
                    }
                ]
            }");

            var categories = new List<PlaceCategory>
            {
                new PlaceCategory { Name = "category1", Id = Guid.NewGuid() },
                new PlaceCategory { Name = "category2", Id = Guid.NewGuid() },
                 new PlaceCategory { Name = "category3", Id = Guid.NewGuid() },
            };

            categories[1].SuperCategoryId = categories[0].Id;
            categories[1].SuperCategory = categories[0];


            var conditions = new List<PlaceCondition>
            {
                new PlaceCondition { Name = "condition1" }
            };

            // Act
            List<ProviderPlace>? result = GeoapifyClient.ParseFeatureCollection(jsonResponse, categories, conditions);

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            var place = result[0];
            Assert.Equal("123", place.ProviderId);
            Assert.Equal("Test Place", place.Name);
            Assert.Equal("Test Country", place.Country);
            Assert.Equal("Test City", place.City);
            Assert.Equal("Test Street", place.Street);
            Assert.Equal("123", place.HouseNumber);
            Assert.Equal(12.34m, place.Latitude);
            Assert.Equal(56.78m, place.Longitude);
            Assert.Single(place.Categories);
            Assert.Equal("category1.category2", place.Categories[0].FullName);
            Assert.Single(place.Conditions);
            Assert.Equal("condition1", place.Conditions[0].FullName);
        }
    }
}
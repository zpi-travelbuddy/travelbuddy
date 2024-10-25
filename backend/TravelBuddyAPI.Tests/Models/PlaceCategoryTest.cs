using System;
using System.Collections.Generic;
using TravelBuddyAPI.Models;

namespace TravelBuddyAPI.Tests.Models
{
    public class PlaceCategoryTest
    {
        [Fact]
        public void GetFullName_NoSuperCategory_ReturnsName()
        {
            // Arrange
            var category = new PlaceCategory
            {
                Name = "Category1"
            };

            // Act
            var fullName = category.FullName;

            // Assert
            Assert.Equal("Category1", fullName);
        }

        [Fact]
        public void GetFullName_WithSuperCategory_ReturnsFullName()
        {
            // Arrange
            var superCategory = new PlaceCategory
            {
                Name = "SuperCategory"
            };
            var category = new PlaceCategory
            {
                Name = "Category1",
                SuperCategory = superCategory,
                SuperCategoryId = superCategory.Id
            };

            // Act
            var fullName = category.FullName;

            // Assert
            Assert.Equal("SuperCategory.Category1", fullName);
        }

        [Fact]
        public void GetFullName_WithNestedSuperCategories_ReturnsFullName()
        {
            // Arrange
            var rootCategory = new PlaceCategory
            {
                Name = "RootCategory"
            };
            var superCategory = new PlaceCategory
            {
                Name = "SuperCategory",
                SuperCategory = rootCategory,
                SuperCategoryId = rootCategory.Id
            };
            var category = new PlaceCategory
            {
                Name = "Category1",
                SuperCategory = superCategory,
                SuperCategoryId = superCategory.Id
            };

            // Act
            var fullName = category.FullName;

            // Assert
            Assert.Equal("RootCategory.SuperCategory.Category1", fullName);
        }

        [Fact]
        public void GetFullName_SuperCategoryIdNotNullButSuperCategoryNull_ReturnsNull()
        {
            // Arrange
            var category = new PlaceCategory
            {
                Name = "Category1",
                SuperCategoryId = Guid.NewGuid()
            };

            // Act
            var fullName = category.FullName;
            // Assert
            Assert.Null(fullName);
        }
    }
}

using System;
using System.Collections.Generic;
using TravelBuddyAPI.Models;
using Xunit;

namespace TravelBuddyAPI.Tests.Models
{
    public class PlaceConditionTest
    {
        [Fact]
        public void GetFullName_NoSuperCondition_ReturnsName()
        {
            // Arrange
            var condition = new PlaceCondition
            {
                Name = "Condition1"
            };

            // Act
            var fullName = condition.FullName;

            // Assert
            Assert.Equal("Condition1", fullName);
        }

        [Fact]
        public void GetFullName_WithSuperCondition_ReturnsFullName()
        {
            // Arrange
            var superCondition = new PlaceCondition
            {
                Name = "SuperCondition"
            };
            var condition = new PlaceCondition
            {
                Name = "Condition1",
                SuperCondition = superCondition,
                SuperConditionId = superCondition.Id
            };

            // Act
            var fullName = condition.FullName;

            // Assert
            Assert.Equal("SuperCondition.Condition1", fullName);
        }

        [Fact]
        public void GetFullName_WithNestedSuperConditions_ReturnsFullName()
        {
            // Arrange
            var rootCondition = new PlaceCondition
            {
                Name = "RootCondition"
            };
            var superCondition = new PlaceCondition
            {
                Name = "SuperCondition",
                SuperCondition = rootCondition,
                SuperConditionId = rootCondition.Id
            };
            var condition = new PlaceCondition
            {
                Name = "Condition1",
                SuperCondition = superCondition,
                SuperConditionId = superCondition.Id
            };

            // Act
            var fullName = condition.FullName;

            // Assert
            Assert.Equal("RootCondition.SuperCondition.Condition1", fullName);
        }

        [Fact]
        public void GetFullName_SuperConditionIdNotNullButSuperConditionNull_ReturnsNull()
        {
            // Arrange
            var condition = new PlaceCondition
            {
                Name = "Condition1",
                SuperConditionId = Guid.NewGuid()
            };

            // Act
            var fullName = condition.FullName;

            // Assert
            Assert.Null(fullName);
        }
    }
}




























































































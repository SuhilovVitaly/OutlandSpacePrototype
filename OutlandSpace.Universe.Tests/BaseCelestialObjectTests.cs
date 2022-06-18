using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutlandSpace.Universe.CelestialObjects;

namespace OutlandSpace.Universe.Tests;

[TestClass()]
public class BaseCelestialObjectTests
{
    [TestMethod()]
    public void SetCurrentLocationTest()
    {
        // Arrange
        var baseCelestialObject = new BaseCelestialObject();
        var locationX = 200;
        var locationY = 300;

        // Act
        baseCelestialObject.Location.Set(new Geometry.PointInSpace(locationX, locationY));

        // Assert
        Assert.AreEqual(baseCelestialObject.Location.Current.X, locationX);
        Assert.AreEqual(baseCelestialObject.Location.Current.Y, locationY);
    }

    [TestMethod()]
    public void SetPreviousLocationTest()
    {
        // Arrange
        var baseCelestialObject = new BaseCelestialObject();
        var locationXPrevious = 200;
        var locationYPrevious = 300;
        var locationXCurrent = 201;
        var locationYCurrent = 301;

        // Act
        baseCelestialObject.Location.Set(new Geometry.PointInSpace(locationXPrevious, locationYPrevious));
        baseCelestialObject.Location.Set(new Geometry.PointInSpace(locationXCurrent, locationYCurrent));

        // Assert
        Assert.AreEqual(baseCelestialObject.Location.Current.X, locationXCurrent);
        Assert.AreEqual(baseCelestialObject.Location.Current.Y, locationYCurrent);
        Assert.AreEqual(baseCelestialObject.Location.Previous.X, locationXPrevious);
        Assert.AreEqual(baseCelestialObject.Location.Previous.Y, locationYPrevious);
    }

    [TestMethod()]
    public void BaseCelestialObjectTypeShouldBeNone()
    {
        // Arrange
        var baseCelestialObject = new BaseCelestialObject();

        // Act

        // Assert
        Assert.AreEqual(baseCelestialObject.Type, CelestialObjectTypes.None);

    }

    [TestMethod()]
    public void SetSpeedTest()
    {
        // Arrange
        var baseCelestialObject = new BaseCelestialObject();
        var speed = 12.01F;

        // Act
        baseCelestialObject.SetSpeed(speed);

        // Assert
        Assert.AreEqual(baseCelestialObject.Speed, speed);
    }

    [TestMethod()]
    public void SetDirectionTest()
    {
        // Arrange
        var baseCelestialObject = new BaseCelestialObject();
        var direction = 217.21F;

        // Act
        baseCelestialObject.SetDirection(direction);

        // Assert
        Assert.AreEqual(baseCelestialObject.Direction, direction);
    }

    [TestMethod()]
    public void SetAgilityTest()
    {
        // Arrange
        var baseCelestialObject = new BaseCelestialObject();
        var agility = 6.88F;

        // Act
        baseCelestialObject.SetAgility(agility);

        // Assert
        Assert.AreEqual(baseCelestialObject.Agility, agility);
    }
}

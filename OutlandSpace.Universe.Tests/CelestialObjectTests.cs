using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OutlandSpace.Universe.Tests;

[TestClass()]
public class CelestialObjectTests
{
    [TestMethod()]
    public void SetLocationTest()
    {
        // Arrange
        var baseCelestialObject = new CelestialObject();
        var locationX = 200;
        var locationY = 300;

        // Act
        baseCelestialObject.SetLocation(new Geometry.PointInSpace(locationX, locationY));

        // Assert
        Assert.AreEqual(baseCelestialObject.Location.X, locationX);
        Assert.AreEqual(baseCelestialObject.Location.Y, locationY);
    }

    [TestMethod()]
    public void SetSpeedTest()
    {
        // Arrange
        var baseCelestialObject = new CelestialObject();
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
        var baseCelestialObject = new CelestialObject();
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
        var baseCelestialObject = new CelestialObject();
        var agility = 6.88F;

        // Act
        baseCelestialObject.SetAgility(agility);

        // Assert
        Assert.AreEqual(baseCelestialObject.Agility, agility);
    }
}

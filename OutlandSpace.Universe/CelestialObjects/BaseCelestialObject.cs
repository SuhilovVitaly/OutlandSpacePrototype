using System;

namespace OutlandSpace.Universe.CelestialObjects;

[Serializable]
public class BaseCelestialObject
{
    /// <summary>
    /// Celestial object identification number
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Celestial object name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Direction from 0 to 360 degrees. 0 - North,  90 - East, 180 - South, 270 - West
    /// </summary>
    public float Direction { get; private set; }

    /// <summary>
    /// Pixels in second
    /// </summary>
    public float Speed { get; private set; }

    /// <summary>
    /// Pixels in second
    /// </summary>
    public float Agility { get; private set; }

    /// <summary>
    /// Current position spacecraft on map.
    /// </summary>
    public CelestialOblectLocation Location { get; private set; } = new CelestialOblectLocation();

    /// <summary>
    /// Type (Asteroid, Spaceship, Missile, etd.)
    /// </summary>
    public CelestialObjectTypes Type { get; set; } = CelestialObjectTypes.None;


    public void SetAgility(float agility)
    {
        Agility = agility;
    }

    public void SetSpeed(float speed)
    {
        Speed = speed;
    }

    public void SetDirection(float direction)
    {
        Direction = direction;
    }
}


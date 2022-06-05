using OutlandSpace.Universe.Geometry;

namespace OutlandSpace.Universe;

public class CelestialObject
{
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
    public PointInSpace Location { get; private set; }

    public void SetLocation(PointInSpace location)
    {
        Location = new PointInSpace(location.X, location.Y);
    }

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


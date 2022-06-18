using OutlandSpace.Universe.Geometry;

namespace OutlandSpace.Universe.CelestialObjects;

public class CelestialOblectLocation
{
    public PointInSpace Current { get; private set; } = new PointInSpace(0, 0);
    public PointInSpace Previous { get; private set; } = new PointInSpace(0, 0);

    public void Set(PointInSpace location)
    {
        Previous = new PointInSpace(Current.X, Current.Y);
        Current = new PointInSpace(location.X, location.Y);        
    }
}

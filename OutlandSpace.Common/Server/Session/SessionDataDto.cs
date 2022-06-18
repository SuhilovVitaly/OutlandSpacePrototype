using OutlandSpace.Universe.CelestialObjects;

namespace OutlandSpace.Common.Server.Session;

[Serializable]
public class SessionDataDto : IGameSessionData
{
    public int Id { get; set; }

    public int Turn { get; set; }

    public bool IsPause { get; set; }

    public List<ICelestialObject> CelestialObjects { get; set; } = new List<ICelestialObject>();

    public bool IsDebug { get; set; }

    public List<ICelestialObject> GetCelestialObjects()
    {
        return CelestialObjects.DeepClone();
    }
}

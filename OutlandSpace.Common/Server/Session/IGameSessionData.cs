using OutlandSpace.Universe.CelestialObjects;

namespace OutlandSpace.Common.Server.Session;

public interface IGameSessionData
{
    int Id { get; set; }

    int Turn { get; }

    bool IsPause { get; set; }

    bool IsDebug { get; set; }

    List<ICelestialObject> GetCelestialObjects();
}

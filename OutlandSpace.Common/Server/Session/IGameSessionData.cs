using OutlandSpace.Universe.CelestialObjects;

namespace OutlandSpace.Common.Server.Session;

public interface IGameSessionData
{
    int Id { get; set; }

    int Turn { get; }

    int Step { get; set; }

    bool IsPause { get; set; }

    string ScenarioName { get; set; }

    bool IsValid { get; set; }

    DateTime LastUpdate { get; set; }

    DateTime ExecuteTime { get; set; }

    List<ICelestialObject> GetCelestialObjects();
}

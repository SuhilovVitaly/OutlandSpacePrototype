using OutlandSpace.Universe.CelestialObjects;

namespace OutlandSpace.Common.Server.Session;

public interface IGameSession : IGameSessionExporter
{
    int Id { get; set; }

    int Turn { get; }

    bool IsPause { get; set; }

    bool IsDebug { get; set; }

    List<ICelestialObject> GetCelestialObjects();

    ICelestialObject GetCelestialObject(int id);

    void FinishTurn();

    void GenerateEmptySpaceMap();

    void GenerateBaseSpaceMap();

    void GenerateDebugSpaceMap();

    void AddCelestialObjects(List<ICelestialObject> celestialObjects);

    void AddCelestialObject(ICelestialObject celestialObject);

    void ReplaceCelestialObjects(List<ICelestialObject> celestialObjects);

}

using OutlandSpace.Universe.CelestialObjects;

namespace OutlandSpace.Common.Server.Session;

public class GameSession: IGameSession
{
    public int Id { get; set; }
    public int Turn { get; private set; }
    public bool IsPause { get; set; }
    public bool IsDebug { get; set; }

    private CelestialMap SpaceMap { get; set; } = new CelestialMap(new List<ICelestialObject>());
    
    public GameSession(IGameSessionData sessionDTO)
    {
        Id = sessionDTO.Id;
        Turn = sessionDTO.Turn;
        IsPause = sessionDTO.IsPause;
        IsDebug = sessionDTO.IsDebug;
        SpaceMap = new CelestialMap(sessionDTO.GetCelestialObjects());
    }

    public IGameSessionData ToGameSession()
    {
        return new SessionDataDto
        {
            Id = Id,
            Turn = Turn,
            IsPause = IsPause,
            IsDebug = IsDebug,
            CelestialObjects = SpaceMap.GetCelestialObjects()
        };
    }

    public List<ICelestialObject> GetCelestialObjects()
    {
        throw new NotImplementedException();
    }

    public ICelestialObject GetCelestialObject(int id)
    {
        throw new NotImplementedException();
    }

    public void FinishTurn()
    {
        throw new NotImplementedException();
    }

    public void GenerateEmptySpaceMap()
    {
        throw new NotImplementedException();
    }

    public void GenerateBaseSpaceMap()
    {
        throw new NotImplementedException();
    }

    public void GenerateDebugSpaceMap()
    {
        throw new NotImplementedException();
    }

    public void AddCelestialObjects(List<ICelestialObject> celestialObjects)
    {
        throw new NotImplementedException();
    }

    public void AddCelestialObject(ICelestialObject celestialObject)
    {
        throw new NotImplementedException();
    }

    public void ReplaceCelestialObjects(List<ICelestialObject> celestialObjects)
    {
        throw new NotImplementedException();
    }
}

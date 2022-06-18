using OutlandSpace.Common.Server;
using OutlandSpace.Common.Server.Session;

namespace OutlandSpace.Engine.Tests;

[TestClass()]
public class LocalEngineTests
{
    [TestMethod()]
    public void LocalServiceShouldBeCreateSuccssed()
    {
        IGameServer localGameServer = new LocalServer();

        var sessionDto = new SessionDataDto
        {
            Id = 100,
            IsDebug = true,
            IsPause = true,
            Turn = 0,
            CelestialObjects = new List<Universe.CelestialObjects.ICelestialObject>()
        };

        var sessionDtoResult = localGameServer.SessionInitialization(sessionDto);

        Assert.AreEqual(sessionDto.Id, sessionDtoResult.Id);
        Assert.AreEqual(sessionDto.IsDebug, sessionDtoResult.IsDebug);
        Assert.AreEqual(sessionDto.IsPause, sessionDtoResult.IsPause);
        Assert.AreEqual(sessionDto.Turn, sessionDtoResult.Turn);

    }
}

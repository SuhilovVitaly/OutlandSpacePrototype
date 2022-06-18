using OutlandSpace.Common.Server;
using OutlandSpace.Common.Server.Session;

namespace OutlandSpace.Engine;

public class LocalServer : IGameServer
{
    public IGameSessionData RefreshGameSession(int id)
    {
        throw new NotImplementedException();
    }

    public IGameSessionData SessionInitialization(IGameSessionData session)
    {
        var gameSession = new GameSession(session);

        return gameSession.ToGameSession();
    }
}

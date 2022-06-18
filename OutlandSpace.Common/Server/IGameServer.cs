using OutlandSpace.Common.Server.Session;

namespace OutlandSpace.Common.Server;

public interface IGameServer
{
    IGameSessionData SessionInitialization(IGameSessionData session);

    IGameSessionData RefreshGameSession(int id);
}

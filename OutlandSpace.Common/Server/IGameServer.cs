using OutlandSpace.Common.Server.Session;

namespace OutlandSpace.Common.Server;

public interface IGameServer
{
    IGameSessionData RefreshGameSession(int id);
    void ResumeSession(int id);

    void PauseSession(int id);

    void Command(int sessionId, string command);

    int GetTurn(int sessionId);

    IGameSessionData Execute(int sessionId, int turns);
}

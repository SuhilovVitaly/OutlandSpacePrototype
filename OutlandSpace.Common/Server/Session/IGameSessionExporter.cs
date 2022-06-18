namespace OutlandSpace.Common.Server.Session;

public interface IGameSessionExporter
{
    IGameSessionData ToGameSession();
}

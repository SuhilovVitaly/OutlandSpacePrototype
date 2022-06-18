using OutlandSpace.Common.Server.Session;
using OutlandSpace.Controller;
using System;

namespace OutlandSpace.Client;

public class GameManager
{
    private readonly Worker _worker;

    public event Action<IGameSessionData> OnStartGame;

    public GameManager(Worker worker)
    {
        _worker = worker;
        _worker.OnStartGame += Event_StartGame;
    }

    public void StartGameSession()
    {
        _worker.StartNewGameSession();
    }

    private void Event_StartGame(IGameSessionData session)
    {
        OnStartGame?.Invoke(session);
    }
}

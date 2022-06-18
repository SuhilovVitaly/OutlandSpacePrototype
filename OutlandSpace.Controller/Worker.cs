using OutlandSpace.Common.Server;
using OutlandSpace.Common.Server.Session;
using OutlandSpace.Common.Tools;
using OutlandSpace.Engine;
using System;
using System.Diagnostics;

namespace OutlandSpace.Controller;

public class Worker : IGameEvents
{
    private readonly IGameServer _gameServer;
    private IGameSessionData _session;

    public event Action<IGameSessionData> OnStartGame;
    public event Action<IGameSessionData> OnEndTurn;
    public event Action<IGameSessionData> OnRefreshLocations;
    public event Action<IGameSessionData, int> OnChangeChangeActiveObject;
    public event Action<IGameSessionData, int> OnChangeChangeSelectedObject;
    public event Action<IGameSessionData, int> OnEndTurnStep;

    public Worker()
    {
        _gameServer = new LocalServer();
    }

    public bool IsRunning()
    {
        return _session != null;
    }

    public void SessionResume()
    {
        //Logger.Info($"Game resumed. Turn is {_session.Turn}");

        //_gameServer.ResumeSession(_session.Id);
    }

    public void SessionPause()
    {
        //Logger.Info($"Game paused. Turn is {_session.Turn}");
    }

    public void StartNewGameSession(int ticks = 25)
    {
        IGameSessionData session = new SessionDataDto
        {
            Id = 100,
            IsDebug = true,
            IsPause = true,
            Turn = 0,
            CelestialObjects = new System.Collections.Generic.List<Universe.CelestialObjects.ICelestialObject>()
        };

        _session = _gameServer.SessionInitialization(session);

        OnStartGame?.Invoke(_session);

        if (ticks <= 0) return;

        Scheduler.Instance.ScheduleTask(1, ticks, GetDataFromServer);
        Scheduler.Instance.ScheduleTask(1, ticks, RefreshLocations);
    }

    private void RefreshLocations()
    {
        //var gameSession = _gameServer.RefreshGameSession(_session.Id);

        //_session = gameSession;

        //OnRefreshLocations?.Invoke(gameSession);

        //Logger.Debug("Refresh Session Data. " +
        //            $"Turn is {_session.Turn} " +
        //            $"Step is {_session.Step} " +
        //            $"Atomic results is {_session.CelestialObjects[1].PositionX:N2}");
    }

    private bool _inProgress;

    public void GetDataFromServer()
    {
        if (_inProgress) return;

        _inProgress = true;

        if (_session == null) throw new NullReferenceException();

        var timeMetricGetGameSession = Stopwatch.StartNew();

        //var lastUpdateDateTime = _session.LastUpdate;

        var gameSession = _gameServer.RefreshGameSession(_session.Id);

        ////gameSession.LastUpdate = DateTime.UtcNow;

        //if (gameSession.Turn > _session.Turn)
        //{
        //    var ms = (gameSession.LastUpdate - _session.LastUpdate).TotalMilliseconds;

        //    //Logger.Debug($"Last update is {ms} ms before. Server answear delay is {(DateTime.UtcNow - gameSession.ExecuteTime).TotalMilliseconds} ms.");

        //    OnEndTurn?.Invoke(gameSession);

        //    _session.Step = 0;

        //    //Logger.Debug($"Turn [{gameSession.Turn}] Get data from server is finished {timeMetricGetGameSession.Elapsed.TotalMilliseconds} ms.");
        //}

        timeMetricGetGameSession.Stop();

        ////Logger.Debug($"Turn [{gameSession.Turn}] Get data from server is finished {timeMetricGetGameSession.Elapsed.TotalMilliseconds} ms.");

        //if (gameSession.IsPause)
        //{
        //    _inProgress = false;
        //    return;
        //}

        _inProgress = false;
    }
}


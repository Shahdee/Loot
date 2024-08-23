using System;
using System.Collections.Generic;
using UnityEngine;

public class UnityEventController : IDisposable
{

    private readonly UnityEventView _unityEventView;
    
    private readonly List<IUpdatable> _updatables;
    
    public UnityEventController(List<IUpdatable> updatables)
    {
        _updatables = updatables;
        
        _unityEventView = new GameObject("UnityEventView").AddComponent<UnityEventView>();
        _unityEventView.ListenUpdate(Update);
        _unityEventView.SetDontDestroy();
    }

    private void Update(float deltaTime)
    {
        foreach (var updatable in _updatables)
        {
            updatable.CustomUpdate(deltaTime);
        }
    }

    public void Dispose()
    {
        _unityEventView.Unlisten();
    }
}

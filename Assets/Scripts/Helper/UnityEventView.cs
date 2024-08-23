
using System;
using UnityEngine;

public class UnityEventView : MonoBehaviour
{
    private Action<float> _update;

    public void ListenUpdate(Action<float> update)
    {
        _update = update;
    }
    
    public void SetDontDestroy()
    {
        DontDestroyOnLoad(gameObject);
    }
    
    private void Update()
    {
        _update?.Invoke(Time.deltaTime);
    }
    
    public void Unlisten()
    {
        _update = null;
    }
}

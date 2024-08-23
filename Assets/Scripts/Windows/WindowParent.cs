using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowParent : IWindowParent
{
    private readonly WindowParentView _windowParentView;
    
    public WindowParent(WindowParentView windowParentView, List<IWindow> windows)
    {
        _windowParentView = windowParentView;

        foreach (var win in windows)
        {
            win.SetParent(_windowParentView.transform);
        }
    }
}

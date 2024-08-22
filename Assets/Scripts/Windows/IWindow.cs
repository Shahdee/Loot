
using UnityEngine;

public interface IWindow
{
    EWindowType WindowType {get;}
    
    void SetParent(Transform parent);
    
    void Open();

    void Close();
}

using UnityEngine;
using System;

public interface IItemStatWindow
{
    public event Action OnOkClick;
    
    void SetItem(ItemModel itemModel);
}

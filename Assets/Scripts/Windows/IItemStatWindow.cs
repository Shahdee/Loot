using UnityEngine;
using System;

public interface IItemStatWindow
{
    event Action OnOkClick;
    event Action OnBackClick;
    
    void SetItem(ItemModel itemModel);
}

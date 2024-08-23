using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStatWindow : AbstractWindow, IItemStatWindow
{
    public override EWindowType WindowType => EWindowType.ItemStat;

    private readonly ItemStatWindowView _view;

    // TODO Check 
    public ItemStatWindow(ItemStatWindowView view) : base(view)
    {
        _view = view;
    }
}

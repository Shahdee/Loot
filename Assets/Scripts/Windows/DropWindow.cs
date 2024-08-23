using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWindow : AbstractWindow, IDropWindow
{
    public override EWindowType WindowType => EWindowType.Drop;

    private readonly DropWindowView _view;

    // TODO Check 
    public DropWindow(DropWindowView view) : base(view)
    {
        _view = view;
    }

    public void SetItems(ItemModel currentItem, ItemModel dropItem)
    {
        
    }
}

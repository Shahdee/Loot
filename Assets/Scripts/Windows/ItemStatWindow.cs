using System;

public class ItemStatWindow : AbstractWindow, IItemStatWindow
{
    public event Action OnOkClick;
    
    public override EWindowType WindowType => EWindowType.ItemStat;

    private readonly ItemStatWindowView _view;
    private readonly IItemIconProvider _itemIconProvider;

    // TODO Check 
    public ItemStatWindow(IItemIconProvider itemIconProvider,
                            ItemStatWindowView view) : base(view)
    {
        _itemIconProvider = itemIconProvider;
        _view = view;

        _view.OnOkClick += () => OnOkClick?.Invoke();
    }

    public void SetItem(ItemModel item)
    {
        if (item == null)
            return;

        var icon = _itemIconProvider.GetItemIcon(item.ItemType);
        var level = item.Level + 1;
        var name = item.ItemType.ToString();
        _view.SetItem(icon, level, name);
    } 

}

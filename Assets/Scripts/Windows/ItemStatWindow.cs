using System;

public class ItemStatWindow : AbstractWindow, IItemStatWindow
{
    public event Action OnOkClick;
    public event Action OnBackClick;
    
    public override EWindowType WindowType => EWindowType.ItemStat;

    private readonly ItemStatWindowView _view;
    private readonly IItemIconProvider _itemIconProvider;
    private readonly IItemStatFormatController _itemStatFormatController;
    
    
    public ItemStatWindow(IItemIconProvider itemIconProvider,
                            IItemStatFormatController itemStatFormatController,
                            ItemStatWindowView view) : base(view)
    {
        _itemIconProvider = itemIconProvider;
        _itemStatFormatController = itemStatFormatController;
        _view = view;

        _view.OnOkClick += () => OnOkClick?.Invoke();
        _view.OnBackClick += () => OnBackClick?.Invoke();
        

    }

    public void SetItem(ItemModel item)
    {
        if (item == null)
            return;

        var icon = _itemIconProvider.GetItemIcon(item.ItemType);
        var level = item.Level + 1;
        var name = item.ItemType.ToString();

        var itemStats = _itemStatFormatController.GetItemStatsFormatted(item.Stats);

        _view.SetItem(icon, level, itemStats, name);
    } 

}

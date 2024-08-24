using System;
using UnityEngine;


public class DropWindow : AbstractWindow, IDropWindow
{
    public event Action OnDropClick;
    public event Action OnEquipClick;
    public event Action OnBackClick;
    
    public override EWindowType WindowType => EWindowType.Drop;

    private readonly IItemIconProvider _itemIconProvider;
    private readonly IItemStatFormatController _itemStatFormatController;
    private readonly DropWindowView _view;
    
    public DropWindow(IItemIconProvider itemIconProvider,
                        IItemStatFormatController itemStatFormatController,
                        DropWindowView view) : base(view)
    {
        _itemIconProvider = itemIconProvider;
        _itemStatFormatController = itemStatFormatController;
        _view = view;

        _view.OnDropClick += () => OnDropClick?.Invoke();
        _view.OnEquipClick += () => OnEquipClick?.Invoke();
        _view.OnBackClick += () => OnBackClick?.Invoke();
    }

    public void SetItems(ItemModel equippedItem, ItemModel lootedItem)
    {
        
        var icon = _itemIconProvider.GetItemIcon(equippedItem.ItemType);
        var level = equippedItem.Level + 1;
        var name = equippedItem.ItemType.ToString();
        
        var itemStats = _itemStatFormatController.GetItemStatsFormatted(equippedItem.Stats);
        
        _view.SetEquippedItem(icon, level, itemStats, name);
        
        icon = _itemIconProvider.GetItemIcon(lootedItem.ItemType);
        level = lootedItem.Level + 1;
        
        itemStats = _itemStatFormatController.GetComparedItemStatsFormatted(equippedItem.Stats, lootedItem.Stats);

        _view.SetLootedItem(icon, level, itemStats);
    }
}

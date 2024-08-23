using UnityEngine;
using System;

public class MainWindow : AbstractWindow, IMainWindow
{
   public event Action OnLootClick;
   public event Action<int> OnInventoryItemClick;

   public override EWindowType WindowType => EWindowType.Main;

   private readonly IItemIconProvider _itemIconProvider;
   private readonly MainWindowView _view;

   // TODO Check 
   public MainWindow(IItemIconProvider itemIconProvider,
         MainWindowView view) : base(view)
   {
      _itemIconProvider = itemIconProvider;
      _view = view;
      
      _view.OnLootClick += LootClick;
      _view.OnInventoryItemClick += InventoryItemClick;

   }

   public void SetMana(int mana) => _view.SetMana(mana);
   public void SetGold(int gold) => _view.SetGold(gold);

   public void SetItem(ItemModel item)
   {
      var index = (int) item.ItemType;
      var icon = _itemIconProvider.GetItemIcon(item.ItemType);
      var level = item.Level + 1;
    
      _view.SetItem(index, icon, level);
   }

   private void LootClick()
   {
      OnLootClick?.Invoke();
   }
   
   private void InventoryItemClick(int index)
   {
      var itemType = (EItemType) index;
      OnInventoryItemClick?.Invoke(index);
   }

}

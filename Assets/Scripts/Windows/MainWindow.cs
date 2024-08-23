using UnityEngine;
using System;

public class MainWindow : AbstractWindow, IMainWindow
{
   public event Action OnLootClick;
   public event Action<int> OnInventoryItemClick;
   
   public override EWindowType WindowType => EWindowType.Main;

   private readonly MainWindowView _view;

   // TODO Check 
   public MainWindow(MainWindowView view) : base(view)
   {
      _view = view;
      _view.OnLootClick += LootClick;
      _view.OnInventoryItemClick += InventoryItemClick;

   }
   
   public void SetMana(int mana) => _view.SetMana(mana);
   public void SetGold(int gold) => _view.SetGold(gold);

   private void LootClick() => OnLootClick?.Invoke();

   private void InventoryItemClick(int index)
   {
      var itemType = (EItemType) index;
      Debug.Log("item " + itemType);
      
      OnInventoryItemClick?.Invoke(index);
      
   }
   
   
   
}

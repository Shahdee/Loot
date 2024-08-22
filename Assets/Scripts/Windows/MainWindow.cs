using UnityEngine;

public class MainWindow : AbstractWindow
{
   public override EWindowType WindowType => EWindowType.Main;

   private readonly MainWindowView _view;

   // TODO Check 
   public MainWindow(MainWindowView view) : base(view)
   {
      _view = view;
      _view.OnLootClick += LootClick;
      _view.OnInventoryItemClick += InventoryItemClick;

   }

   private void LootClick()
   {
      
   }
   
   private void InventoryItemClick(int index)
   {
      var itemType = (EItemType) index;
      Debug.Log("item " + itemType);
      
      
   }
}

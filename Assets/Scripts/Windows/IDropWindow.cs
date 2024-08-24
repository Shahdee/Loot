using System;

public interface IDropWindow
{
    event Action OnDropClick;
    event Action OnEquipClick;
    event Action OnBackClick;
    
    
    void SetItems(ItemModel equippedItem, ItemModel lootedItem);
}

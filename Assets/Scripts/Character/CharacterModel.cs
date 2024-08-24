using System;
using UnityEngine;

public class CharacterModel : ICharacterModel
{
    public ItemModel Loot => _lootedItem;
    
    private ItemModel[] _equippedItems;
    private ItemModel _lootedItem;

    public CharacterModel()
    {
        var itemCount =  Enum.GetValues( typeof( EItemType ) ).Length;
        Debug.LogError(" itemCount " + itemCount);
        _equippedItems = new ItemModel[itemCount];
    }
    

    public bool HasLoot() => _lootedItem != null;

    public int GetCurrentLevelForItem(EItemType itemType)
    {
        var index = (int) itemType;
        if (_equippedItems[index] == null)
            return 0;
        
        return _equippedItems[index].Level;
    }

    public int[] GetCurrentStatsForItem(EItemType itemType)
    {
        var index = (int) itemType;

        if (_equippedItems[index] == null)
            return null;

        _equippedItems[index].Stats[0] = 0;

        return _equippedItems[index].Stats;
    }

    public ItemModel GetEquippedItem(EItemType itemType)
    {
        var index = (int) itemType;
        return _equippedItems[index];
    }

    public void EquipItem(ItemModel itemModel)
    {
        var index = (int) itemModel.ItemType;
        _equippedItems[index] = itemModel;
    } 
    
    public void SetLoot(ItemModel itemModel)
    {
        _lootedItem = itemModel;
    }
    
}

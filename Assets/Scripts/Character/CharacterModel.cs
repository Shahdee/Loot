using System;
using UnityEngine;

public class CharacterModel : ICharacterModel
{
    private ItemModel[] _currentItems;
    private ItemModel _droppedItem;

    public CharacterModel()
    {
        var itemCount =  Enum.GetValues( typeof( EItemType ) ).Length;
        Debug.LogError(" itemCount " + itemCount);
        _currentItems = new ItemModel[itemCount];
    }
    

    public bool HasDrop() => _droppedItem != null;

    public int GetCurrentLevelForItem(EItemType itemType)
    {
        var index = (int) itemType;
        if (_currentItems[index] == null)
            return 0;
        
        return _currentItems[index].Level;
    }

    public int[] GetCurrentStatsForItem(EItemType itemType)
    {
        var index = (int) itemType;

        if (_currentItems[index] == null)
            return null;

        _currentItems[index].Stats[0] = 0;

        return _currentItems[index].Stats;
    }

    public ItemModel GetCurrentItem(EItemType itemType)
    {
        var index = (int) itemType;
        return _currentItems[index];
    }

    public void AddItem(ItemModel itemModel)
    {
        var index = (int) itemModel.ItemType;
        _currentItems[index] = itemModel;
    }
}

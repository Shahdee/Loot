using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterModel : ICharacterModel
{

    // stats 
    // items 

    private ItemModel[] _currentItems;
    private ItemModel _droppedItem;

    public CharacterModel()
    {
        var itemCount =  Enum.GetValues( typeof( EItemType ) ).Length;
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

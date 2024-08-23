using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel : IItemModel
{
    public EItemType ItemType => _itemType;

    public int Level => _level;
    
    // characteristics - indexer ? 

    private EItemType _itemType;
    private int _level;
    private int[] _characteristics;

    public ItemModel(EItemType itemType, int level)
    {
        _itemType = itemType;
        _level = level;
    }
}

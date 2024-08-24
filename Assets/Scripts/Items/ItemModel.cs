using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel : IItemModel
{
    public int[] Stats => _stats;
    public EItemType ItemType => _itemType;

    public int Level => _level;

    private readonly EItemType _itemType;
    private readonly int _level;
    private readonly int[] _stats; 

    public ItemModel(EItemType itemType, int level, int[] stats)
    {
        _itemType = itemType;
        _level = level;
        _stats = stats;
    }
}

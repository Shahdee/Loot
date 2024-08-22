using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData 
{

    private readonly EItemType _itemType;

    private int _level;

    private int[] _stats;

    // TODO - rare - ?

    public ItemData(EItemType itemType)
    {
        _itemType = itemType;

        var count = Enum.GetValues(typeof(EItemStat)).Length;
        _stats = new int[count];

        // TODO randomize 
        // TODO level 
        
    }

    public int[] GetAllStats() => _stats;

    public int GetStats(EItemStat itemStat) => _stats[(int)itemStat];

}

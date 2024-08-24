using System;
using UnityEngine;


public class ItemStatFormatController : IItemStatFormatController
{
    private const string STAT_FORMAT_DEFAULT = "{0}: {1}";
    private const string STAT_FORMAT_BETTER = "{0}: <color=green>{1}</color>";
    private const string STAT_FORMAT_WORSE = "{0}: <color=red>{1}</color>";
    
    private string[] _itemStats;

    public ItemStatFormatController()
    {
        var statCount =  Enum.GetValues( typeof( EItemStat ) ).Length; 
        _itemStats = new string[statCount];
    }

    public string[] GetItemStatsFormatted(int[] stats)
    {
        if (_itemStats.Length != stats.Length)
            return null;
        
        for (int i = 0; i < _itemStats.Length; i++)
        {
            _itemStats[i] = String.Format(STAT_FORMAT_DEFAULT, (EItemStat) i, stats[i]);
        }

        return _itemStats;
    }
    
    public string[] GetComparedItemStatsFormatted(int[] equippedStats, int[] lootedStats)
    {
        if (_itemStats.Length != equippedStats.Length || _itemStats.Length != lootedStats.Length)
        {
            return null;
        }
            
        
        for (int i = 0; i < _itemStats.Length; i++)
        {
            var stat = lootedStats[i] - equippedStats[i];
            if (stat == 0)
            {
                _itemStats[i] = String.Format(STAT_FORMAT_DEFAULT, (EItemStat) i, lootedStats[i]);
                continue;
            }

            if (stat > 0)
            {
                _itemStats[i] = String.Format(STAT_FORMAT_BETTER, (EItemStat) i, lootedStats[i]);
            }
            else
            {
                _itemStats[i] = String.Format(STAT_FORMAT_WORSE, (EItemStat) i, lootedStats[i]);
            }
        }
        return _itemStats;
    }
}

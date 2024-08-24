
using System.Linq;
using UnityEngine;

public class ItemStatDataProvider : IItemStatDataProvider
{
    public int LevelRandomDelta => _itemStatAsset.LevelRandomDelte;
    public int StatRandomDelta => _itemStatAsset.StatRandomDelta;
    
    private readonly ItemStatAsset _itemStatAsset;
    
    public ItemStatDataProvider(ItemStatAsset itemStatAsset)
    {
        _itemStatAsset = itemStatAsset;
    }

    public int GetItemSellPrice(EItemType itemType)
    {
        var item = _itemStatAsset.ItemStatDatas.First(x => x.ItemType == itemType);

        if (item == null)
        {
            Debug.Log("no such item");
            return -1;
        }

        return item.SellPrice;

    }

    public int[] GetItemStats(EItemType itemType)
    {
        var item = _itemStatAsset.ItemStatDatas.First(x => x.ItemType == itemType);

        if (item == null)
        {
            Debug.Log("no such item");
            return null;
        }
        
        return item.Stats;
    }
}

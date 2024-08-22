using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// TODO - check
public class ItemIconProvider : IItemIconProvider
{
    private readonly ItemIconAsset _itemIconAsset;

    public ItemIconProvider(ItemIconAsset itemIconAsset)
    {
        _itemIconAsset = itemIconAsset;
    }

    public Sprite GetItemIcon(EItemType itemType) => _itemIconAsset.GetIcon(itemType);
}

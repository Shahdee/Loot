using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemIconAsset", menuName = "SO / ItemIconAsset" ,order = 2)]
public class ItemIconAsset : ScriptableObject
{
    public Sprite GetIcon(EItemType itemType) 
    {
      var item = _itemIconData.Find(x => x.ItemType == itemType); 
      if (item != null)
        return item.Icon; 

        return null;
    } 
    
    [SerializeField] private List<ItemIconData> _itemIconData;
}

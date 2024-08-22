using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemIconProvider 
{
    Sprite GetItemIcon(EItemType itemType);
}

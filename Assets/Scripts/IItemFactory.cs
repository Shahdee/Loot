using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemFactory 
{
    ItemData Create(EItemType itemType);
}

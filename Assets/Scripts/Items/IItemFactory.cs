using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItemFactory
{
    EItemType GetRandomItemType();
    ItemModel Create(IItemModel itemPrototype, EItemType itemType);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterModel
{
   bool HasDrop();

   int GetCurrentLevelForItem(EItemType itemType);

   ItemModel GetCurrentItem(EItemType itemType);

   void AddItem(ItemModel itemModel);
}

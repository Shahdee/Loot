using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterModel
{
   ItemModel Loot { get; }

   bool HasLoot();

   int GetCurrentLevelForItem(EItemType itemType);

   int[] GetCurrentStatsForItem(EItemType itemType);

   ItemModel GetEquippedItem(EItemType itemType);

   void EquipItem(ItemModel itemModel);
   void SetLoot(ItemModel itemModel);
}

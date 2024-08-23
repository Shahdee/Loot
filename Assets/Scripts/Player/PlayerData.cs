using System;
using UnityEngine;

[Serializable]
public class PlayerData 
{
   public int DefaultMana;

   public int DefaultGold;

   [Tooltip(" seconds")]
   public int ManaReplenishSpeed;  
   
   public int ManaReplenishValue; 
   
   public int LootPrice;  
}

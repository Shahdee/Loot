using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData 
{
   public int DefaultMana;

   public int DefaultGold;

   [Tooltip(" 1 mana in X seconds")]
   public int ManaReplenishSpeed; // [sec] 
}

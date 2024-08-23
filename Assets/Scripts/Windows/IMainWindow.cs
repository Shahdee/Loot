using System;
using UnityEngine;

public interface IMainWindow
{
    event Action OnLootClick;
    event Action<int> OnInventoryItemClick;
    void SetMana(int mana);
    void SetGold(int gold);
}

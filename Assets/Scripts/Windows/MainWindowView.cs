using System;
using UnityEngine.UI;
using UnityEngine;

public class MainWindowView : AbstractWindowView
{
    public event Action OnLootClick;
    public event Action<int> OnInventoryItemClick;

    [SerializeField] private ResourceCounter _manaCounter;
    [SerializeField] private ResourceCounter _goldCounter;

    [SerializeField] private InventoryView _inventoryView;

    [SerializeField] private Button _lootBtn;


    public void Awake()
    {
        _lootBtn.onClick.AddListener(LootClick);
        _inventoryView.OnItemClick += InventoryItemClick;
    }

    public void SetMana(int mana) => _manaCounter.SetAmount(mana);
    public void SetGold(int gold) => _goldCounter.SetAmount(gold);

    public void BlockLoot(bool block)
    {
        _lootBtn.enabled = block; // TODO check
    }

    private void LootClick() => OnLootClick?.Invoke();

    private void InventoryItemClick(int index) => OnInventoryItemClick?.Invoke(index);


}

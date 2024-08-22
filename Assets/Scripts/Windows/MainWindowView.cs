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

    private void LootClick() => OnLootClick?.Invoke();

    private void InventoryItemClick(int index) => OnInventoryItemClick?.Invoke(index);


}

using System;
using UnityEngine;
using UnityEngine.UI;

public class DropWindowView : AbstractWindowView
{
    public event Action OnDropClick;
    public event Action OnEquipClick;
    public event Action OnBackClick;
    
    [SerializeField] private Text _name;
    [SerializeField] private ItemParamsView _currItemParamsView;
    [SerializeField] private ItemParamsView _lootItemParamsView;
    [SerializeField] private Button _btnDrop;
    [SerializeField] private Button _btnEquip;
    [SerializeField] private Button _btnBack;

    public void Awake()
    {
        _btnDrop.onClick.AddListener(()=> OnDropClick?.Invoke());
        _btnEquip.onClick.AddListener(()=> OnEquipClick?.Invoke());
        _btnBack.onClick.AddListener(()=> OnBackClick?.Invoke());
    }
    
    
    public void SetEquippedItem(Sprite icon, int level, string[] stats, string name)
    {
        _name.text = name;
        _currItemParamsView.SetItem(icon, level, stats);
    }
    
    public void SetLootedItem(Sprite icon, int level, string[] stats)
    {
        _lootItemParamsView.SetItem(icon, level, stats);
    }
    
}

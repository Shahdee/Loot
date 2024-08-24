using System;
using UnityEngine;
using UnityEngine.UI;


public class ItemStatWindowView : AbstractWindowView
{
    public event Action OnOkClick;
    public event Action OnBackClick;
    
    [SerializeField] private Text _name;
    [SerializeField] private ItemParamsView _itemParamsView;
    [SerializeField] private Button _btnOk;
    [SerializeField] private Button _btnBack;

    public void Awake()
    {
        _btnOk.onClick.AddListener(()=> OnOkClick?.Invoke());
        _btnBack.onClick.AddListener(()=> OnBackClick?.Invoke());
    }
    
    public void SetItem(Sprite icon, int level, string[] stats, string name)
    {
        _name.text = name;
        _itemParamsView.SetItem(icon, level, stats);
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;


public class ItemStatWindowView : AbstractWindowView
{
    public event Action OnOkClick;
    
    [SerializeField] private Text _name;
    [SerializeField] private ItemParamsView _itemParamsView;
    [SerializeField] private Button _btnOk;

    public void Awake()
    {
        _btnOk.onClick.AddListener(()=> OnOkClick?.Invoke());
    }
    
    public void SetItem(Sprite icon, int level, string name)
    {
        _name.text = name;
        
        _itemParamsView.SetItem(icon, level);
    }
}

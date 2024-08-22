using UnityEngine;
using UnityEngine.UI;
using System;

public class ItemButton : MonoBehaviour
{
    public event Action OnClick;
    
    [SerializeField] private Button _button;
    [SerializeField] private Image _icon;
    
    public void Awake()
    {
        _button.onClick.AddListener(ItemClick);
    }

    public void SetIcon(Sprite sprite)
    {
        _icon.sprite = sprite;
    }

    private void ItemClick() => OnClick?.Invoke();
}

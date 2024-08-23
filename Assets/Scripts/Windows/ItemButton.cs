using UnityEngine;
using UnityEngine.UI;
using System;

public class ItemButton : MonoBehaviour
{
    public event Action OnClick;
    
    [SerializeField] private Button _button;
    [SerializeField] private Image _icon;
    [SerializeField] private Text _level;
    
    public void Awake()
    {
        _button.onClick.AddListener(ItemClick);
    }

    public void SetIcon(Sprite icon)
    {
        _icon.sprite = icon;
    }

    public void SetLevel(int level)
    {
        _level.text = level.ToString();
    }

    private void ItemClick() => OnClick?.Invoke();
}

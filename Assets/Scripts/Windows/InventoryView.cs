using UnityEngine;
using System;

public class InventoryView : MonoBehaviour
{
    public event Action<int> OnItemClick;
    
    [SerializeField] private ItemButton[] _items;

    public void Awake()
    {
        for (int i = 0; i < _items.Length; i++)
        {
            var index = i;
            
            // TODO check 
            _items[i].OnClick += () =>
            {
                OnItemClick?.Invoke(index);
            };
        }
    }

    public void SetItem(int index, Sprite icon, int level)
    {
        _items[index].SetIcon(icon);
        _items[index].SetLevel(level);
    }
    
    
}

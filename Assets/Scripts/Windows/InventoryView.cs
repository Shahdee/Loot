using UnityEngine;
using System;

public class InventoryView : MonoBehaviour
{
    public event Action<int> OnItemClick;
    
    [SerializeField] private ItemButton[] _items;

    public void Awake()
    {
        var index = 0;
        for (int i = 0; i < _items.Length; i++)
        {
            index = i;
            
            // TODO check 
            _items[i].OnClick += () =>
            {
                Debug.Log("btn click " + index);
                OnItemClick?.Invoke(index);
            };
        }
    }
    
    
}

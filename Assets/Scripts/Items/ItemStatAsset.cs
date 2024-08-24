using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName =  "ItemStatAsset", menuName = "SO / ItemStatAsset", order = 3)]
public class ItemStatAsset : ScriptableObject
{
    public IReadOnlyList<ItemStatData> ItemStatDatas => _itemStatData;

    public int LevelRandomDelte => _levelRandomDelte;
    public int StatRandomDelta => _statRandomDelta;
    
    [SerializeField] private  int _levelRandomDelte;
    [SerializeField] private  int _statRandomDelta;
        
    [SerializeField] private List<ItemStatData> _itemStatData;
}

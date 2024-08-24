
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemFactory : IItemFactory
{

    private readonly int _itemCount;
    private readonly ICharacterModel _characterModel;
    private readonly IItemStatDataProvider _itemStatDataProvider;

    private int[] _randomStats;
    
    public ItemFactory(ICharacterModel characterModel, 
                        IItemStatDataProvider itemStatDataProvider)
    {
        _itemCount = Enum.GetValues( typeof( EItemType ) ).Length;
        _characterModel = characterModel;
        _itemStatDataProvider = itemStatDataProvider;

        var statCount = Enum.GetValues( typeof( EItemStat ) ).Length;
        _randomStats = new int[statCount];
    }
    
    public EItemType GetRandomItemType() => (EItemType)Random.Range(0, _itemCount);


    public ItemModel Create(IItemModel itemPrototype, EItemType itemType)
    {
        if (itemPrototype == null)
        {
            var level = 0;
            var stats = _itemStatDataProvider.GetItemStats(itemType);
            
            return new ItemModel(itemType, level, stats);
        }
        else
        {
            var baseLevel = _characterModel.GetCurrentLevelForItem(itemType);
            var level = GetRandomLevel(baseLevel);
            var stats = GetRandomStats(itemPrototype.Stats);
        
            return new ItemModel(itemType, level, stats);
        }
    }


    private int GetRandomLevel(int baseLevel)
    {
        return baseLevel + Random.Range(0, _itemStatDataProvider.LevelRandomDelta + 1);
    }

    private int[] GetRandomStats(int[] prototypeStats)
    {
        if (_randomStats.Length != prototypeStats.Length)
            return null;

        for (int i = 0; i < _randomStats.Length; i++)
        {
            var statDelta = Random.Range(0, _itemStatDataProvider.StatRandomDelta);
            statDelta = Random.Range(0, 2) == 1 ? statDelta * ( -1 ) : statDelta;
            _randomStats[i] = Mathf.Max(0,prototypeStats[i] + statDelta);
            
            // Debug.Log("base " + prototypeStats[i] + " => " + _randomStats[i]);
        }

        return _randomStats;
    }
}

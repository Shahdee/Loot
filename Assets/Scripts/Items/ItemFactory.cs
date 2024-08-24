
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemFactory : IItemFactory
{

    private readonly int _itemCount;
    private readonly ICharacterModel _characterModel;
    
    
    public ItemFactory(ICharacterModel characterModel)
    {
        _itemCount = Enum.GetValues( typeof( EItemType ) ).Length;
        _characterModel = characterModel;
    }

    public ItemModel Create()
    {
        var randomItemType = GetRandomItemType();

        return Create(randomItemType);
    }

    public ItemModel Create(EItemType itemType)
    {
        var baseLevel = _characterModel.GetCurrentLevelForItem(itemType);
        Debug.Log("Create " + itemType + " of level " + baseLevel);
        
        var level = GetRandomLevel(baseLevel);
        var stats = GetRandomStats();
        
        return new ItemModel(itemType, level, stats);

    }


    private int GetRandomLevel(int baseLevel)
    {
        return baseLevel;
    }

    private int[] GetRandomStats()
    {
        return new int[6];
    }


    private EItemType GetRandomItemType()
    {
        return (EItemType)Random.Range(0, _itemCount);
    }
}

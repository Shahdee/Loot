
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
        var level = _characterModel.GetCurrentLevelForItem(itemType);
        Debug.Log("Create " + itemType + " of level " + level);
        
        // randomize level 
        // randomize stats
        
        return new ItemModel(itemType, level);

    }


    private EItemType GetRandomItemType()
    {
        return (EItemType)Random.Range(0, _itemCount + 1);
    }
}

using System;
using UnityEngine;

public class PlayerDataProvider : IPlayerDataProvider
{
    private readonly PlayerAsset _playerAsset;
    
    public PlayerDataProvider(PlayerAsset playerAsset)
    {
        _playerAsset = playerAsset;

        Debug.Log("Hello! ");
    }
    
    
}

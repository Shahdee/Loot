using System;
using UnityEngine;

public class PlayerDataProvider : IPlayerDataProvider
{
    private readonly PlayerAsset _playerAsset;
    
    public PlayerDataProvider(PlayerAsset playerAsset)
    {
        _playerAsset = playerAsset;
    }
    
    public int GetDefaultMana() => _playerAsset.PlayerData.DefaultMana;

    public int GetManaReplenishSpeed() => _playerAsset.PlayerData.ManaReplenishSpeed;
    public int GetManaReplenishValue() => _playerAsset.PlayerData.ManaReplenishValue;

    public int GetDefaultGold() => _playerAsset.PlayerData.DefaultGold;

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="PlayerAsset", menuName="SO / PlayerAsset", order = 1)]
public class PlayerAsset : ScriptableObject
{
    // TODO - check 
    public PlayerData PlayerData => _playerData;
    
    [SerializeField] private PlayerData _playerData;
}

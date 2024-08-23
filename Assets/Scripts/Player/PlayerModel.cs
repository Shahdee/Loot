
    using System;
    using UnityEngine;

    public class PlayerModel : IPlayerModel, IUpdatable
    {
        public event Action<int> OnManaChange;
        public event Action<int> OnGoldChange;

        public int Mana => _currentMana;
        public int Gold => _currentGold;
        public int LootPrice => _lootPrice;

        private int _currentMana;
        
        private int _currentGold;

        private float _manaReplenishSpeed;
        
        private int _manaReplenishValue;
        
        private int _lootPrice;
        
        
        private readonly IPlayerDataProvider _playerDataProvider;
        
        public PlayerModel(IPlayerDataProvider playerDataProvider)
        {
            _playerDataProvider = playerDataProvider;
            
            _currentMana = _playerDataProvider.GetDefaultMana();
            _currentGold = _playerDataProvider.GetDefaultGold();
            
            _manaReplenishSpeed = _playerDataProvider.GetManaReplenishSpeed();
            _manaReplenishValue = _playerDataProvider.GetManaReplenishValue();
            _lootPrice = _playerDataProvider.GetLootPrice();
        }

        public bool isEnoughMana(int mana) => (mana < _currentMana);
        
        public bool SpendMana(int mana)
        {
            if (isEnoughMana(mana))
            {
                AddMana(-mana);
                return true;
            }
            return false;
        }

        public void AddGold(int gold)
        {
            _currentGold += gold;
            OnGoldChange?.Invoke(_currentGold);
        }

        private void AddMana(int value)
        {
            _currentMana += value;
            OnManaChange?.Invoke(_currentMana);
            
            Debug.Log("Add mana " + value);
        }


        private float _currentReplenishTime;

        public void CustomUpdate(float deltaTime)
        {
            _currentReplenishTime += deltaTime;

            if (_currentReplenishTime >= _manaReplenishSpeed)
            {
                _currentReplenishTime = 0;
                AddMana(_manaReplenishValue);
            }
        }
    }

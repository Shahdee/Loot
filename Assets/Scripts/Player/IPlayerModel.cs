using System;

    public interface IPlayerModel
    {
        event Action<int> OnManaChange;
        event Action<int> OnGoldChange;
        
        int Mana { get; }
        int Gold { get; }
        int LootPrice { get; }

        bool isEnoughMana(int value);
        bool SpendMana(int value);
        void AddGold(int value);
    }
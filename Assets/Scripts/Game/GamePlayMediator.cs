using UnityEngine;

public class GamePlayMediator : IGamePlayMediator
{
    private readonly IWindowController _windowController;
    private readonly IPlayerModel _playerModel;
    private readonly ICharacterModel _characterModel;
    private readonly IItemFactory _itemFactory;
    private readonly IItemStatDataProvider _itemStatDataProvider;

    private readonly IMainWindow _mainWindow;
    private readonly IDropWindow _dropWindow;
    private readonly IItemStatWindow _itemStatWindow;
    
    
    public GamePlayMediator(IWindowController windowController,
                            IPlayerModel playerModel,
                            ICharacterModel characterModel,
                            IItemFactory itemFactory,
                            IItemStatDataProvider itemStatDataProvider,
                            IDropWindow dropWindow,
                            IMainWindow mainWindow,
                            IItemStatWindow itemStatWindow)
    {
        _windowController = windowController;
        _playerModel = playerModel;
        _characterModel = characterModel;
        _itemFactory = itemFactory;
        _itemStatDataProvider = itemStatDataProvider;

        _mainWindow = mainWindow;
        _dropWindow = dropWindow;
        _itemStatWindow = itemStatWindow;
        
        _playerModel.OnManaChange += ManaChange;
        // _playerModel.OnGoldChange += ;

        _mainWindow.OnLootClick += LootClick;
        _mainWindow.OnInventoryItemClick += InventoryClick;

        _itemStatWindow.OnOkClick += BackClick;
        _itemStatWindow.OnBackClick += BackClick;

        _dropWindow.OnDropClick += DropClick;
        _dropWindow.OnEquipClick += EquipClick;
        _dropWindow.OnBackClick += BackClick;

    }

    private void ManaChange(int mana)
    {
        // block button if not enough 
    }

    private void LootClick()
    {
        if (_playerModel.isEnoughMana(_playerModel.LootPrice))
        {
            if (_characterModel.HasLoot())
            {
                var lootedItem = _characterModel.Loot;
                var equippedItem = _characterModel.GetEquippedItem(lootedItem.ItemType);
                
                _dropWindow.SetItems(equippedItem, lootedItem);
                _windowController.OpenWindow(EWindowType.Drop);
                return;
            }
            

            if (_playerModel.SpendMana(_playerModel.LootPrice))
            {
                var randomItemType = _itemFactory.GetRandomItemType();
                var equippedItem = _characterModel.GetEquippedItem(randomItemType);
                
                var lootedItem = _itemFactory.Create(equippedItem, randomItemType);

                if (equippedItem == null)
                {
                    _characterModel.EquipItem(lootedItem);
                    _mainWindow.SetItem(lootedItem);
                }
                else
                {
                    _characterModel.SetLoot(lootedItem);
                    _dropWindow.SetItems(equippedItem, lootedItem);
                    _windowController.OpenWindow(EWindowType.Drop);
                }
            }
        }
        else
        {
            Debug.Log("not enough mana ");
        }
    }
    
    private void InventoryClick(int index)
    {
        var itemType = (EItemType) index;
        var item = _characterModel.GetEquippedItem(itemType);

        if (item != null)
        {
            _itemStatWindow.SetItem(item);
            _windowController.OpenWindow(EWindowType.ItemStat);
        }
        else
        {
            Debug.Log("No item.. of " + itemType);
        }
    }

    private void BackClick()
    {
        _windowController.GoBack();
    }

    private void DropClick()
    {
        var lootedItem = _characterModel.Loot;
        var sellPrice = _itemStatDataProvider.GetItemSellPrice(lootedItem.ItemType);
        _playerModel.AddGold(sellPrice);
        _characterModel.SetLoot(null);
        
        _windowController.GoBack();
    }

    private void EquipClick()
    {
        var lootedItem = _characterModel.Loot;
        var equippedItem = _characterModel.GetEquippedItem(lootedItem.ItemType);
        _characterModel.SetLoot(equippedItem);
        _characterModel.EquipItem(lootedItem);
        
        _mainWindow.SetItem(lootedItem);
        
        _dropWindow.SetItems(lootedItem, equippedItem);
    }
}

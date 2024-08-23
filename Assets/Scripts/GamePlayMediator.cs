using UnityEngine;

public class GamePlayMediator : IGamePlayMediator
{
    private readonly IWindowController _windowController;
    private readonly IPlayerModel _playerModel;
    private readonly ICharacterModel _characterModel;
    private readonly IItemFactory _itemFactory;
    private readonly IItemIconProvider _itemIconProvider;
    
    private readonly IMainWindow _mainWindow;
    private readonly IDropWindow _dropWindow;
    private readonly IItemStatWindow _itemStatWindow;
    
    
    public GamePlayMediator(IWindowController windowController,
                            IPlayerModel playerModel,
                            ICharacterModel characterModel,
                            IItemFactory itemFactory,
                            IItemIconProvider itemIconProvider,
                            
                            IDropWindow dropWindow,
                            IMainWindow mainWindow,
                            IItemStatWindow itemStatWindow)
    {
        _windowController = windowController;
        _playerModel = playerModel;
        _characterModel = characterModel;
        _itemFactory = itemFactory;
        _itemIconProvider = itemIconProvider;

        _mainWindow = mainWindow;
        _dropWindow = dropWindow;
        _itemStatWindow = itemStatWindow;
        
        _playerModel.OnManaChange += ManaChange;
        // _playerModel.OnGoldChange += ;

        _mainWindow.OnLootClick += LootClick;
        _mainWindow.OnInventoryItemClick += InventoryClick;

        _itemStatWindow.OnOkClick += StatOkClick;

    }

    private void ManaChange(int mana)
    {
        // block button if not enough 
    }

    private void LootClick()
    {
        if (_playerModel.isEnoughMana(_playerModel.LootPrice))
        {
            if (_characterModel.HasDrop())
                return;

            if (_playerModel.SpendMana(_playerModel.LootPrice))
            {
                var dropItem = _itemFactory.Create();
                var currentItem = _characterModel.GetCurrentItem(dropItem.ItemType);

                if (currentItem == null)
                {
                    _characterModel.AddItem(dropItem);

                   

                    _mainWindow.SetItem(dropItem);
                    
                    Debug.Log("new item");
                }
                else
                {
                    // _dropWindow.SetItems(currentItem, dropItem);
                
                    // get new item 
                    // give it to character - add drop - ? 
                    // show window 
                    // equip 
                    // sell 
                    // exchange 
                    
                    Debug.Log("exchange");
                }
            }
        }
    }
    
    private void InventoryClick(int index)
    {
        var itemType = (EItemType) index;
        var item = _characterModel.GetCurrentItem(itemType);

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

    private void StatOkClick()
    {
        _windowController.GoBack();
    }
}

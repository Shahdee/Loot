using UnityEngine;

public class GamePlayMediator : IGamePlayMediator
{
    private readonly IWindowController _windowController;
    private readonly IPlayerModel _playerModel;
    
    private readonly IMainWindow _mainWindow;
    private readonly IDropWindow _dropWindow;
    private readonly IItemStatWindow _itemStatWindow;
    
    
    public GamePlayMediator(IWindowController windowController,
                            IPlayerModel playerModel,
                            
                            IDropWindow dropWindow,
                            IMainWindow mainWindow,
                            IItemStatWindow itemStatWindow)
    {
        _windowController = windowController;
        _playerModel = playerModel;

        _mainWindow = mainWindow;
        _dropWindow = dropWindow;
        _itemStatWindow = itemStatWindow;


        _playerModel.OnManaChange += ManaChange;
        // _playerModel.OnGoldChange += ;


        _mainWindow.OnLootClick += LootClick;
        _mainWindow.OnInventoryItemClick += InventoryClick;

    }

    private void ManaChange(int mana)
    {
        
    }

    private void LootClick()
    {
        Debug.Log("LootClick ");
    }
    
    private void InventoryClick(int index)
    {
        // show window 
    }
}

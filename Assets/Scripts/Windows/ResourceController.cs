namespace Windows
{
    public class ResourceController : IResourceController
    {
        private readonly IMainWindow _mainWindow;
        private readonly IPlayerModel _playerModel;

        public ResourceController(IMainWindow mainWindow, 
                                    IPlayerModel playerModel)
        {
            _mainWindow = mainWindow;
            _playerModel = playerModel;
            
            _playerModel.OnManaChange += ManaChange;
            _playerModel.OnGoldChange += GoldChange;
            
            _mainWindow.SetMana(_playerModel.Mana);
            _mainWindow.SetGold(_playerModel.Gold);
        }

        private void ManaChange(int mana) => _mainWindow.SetMana(mana);

        private void GoldChange(int gold) => _mainWindow.SetGold(gold);
        
    }
}
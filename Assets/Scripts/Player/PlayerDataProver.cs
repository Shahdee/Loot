namespace DefaultNamespace
{
    public class PlayerDataProver : IPlayerDataProvider
    {
        private readonly PlayerAsset _playerAsset;
        
        public PlayerDataProver(PlayerAsset playerAsset)
        {
            _playerAsset = playerAsset;
        }
        
        
    }
}
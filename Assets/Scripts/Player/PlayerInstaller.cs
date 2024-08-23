using Zenject;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerInstaller", menuName = "SO/Zenject/PlayerInstaller")]
public class PlayerInstaller : ScriptableObjectInstaller
{
    [SerializeField] private PlayerAsset _playerAsset; 
    
    public override void InstallBindings()
    {
        Container.BindInstance(_playerAsset).AsSingle();
        Container.BindInterfacesTo<PlayerDataProvider>().AsSingle();
    }
}

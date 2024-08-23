using Zenject;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerInstaller", menuName = "SO/Zenject/PlayerInstaller")]
public class PlayerInstaller : ScriptableObjectInstaller
{
    [SerializeField] private PlayerAsset _plAsset;
    
    public override void InstallBindings()
    {
        Container.BindInstance(_plAsset).AsSingle();
        
        Container.BindInterfacesTo<PlayerDataProvider>().AsSingle();
        Container.BindInterfacesTo<PlayerModel>().AsSingle();
    }
}

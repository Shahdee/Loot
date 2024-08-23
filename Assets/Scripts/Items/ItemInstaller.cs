using Zenject;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemInstaller", menuName = "SO/Zenject/ItemInstaller")]
public class ItemInstaller : ScriptableObjectInstaller
{
    [SerializeField] private ItemIconAsset _itemIconAsset;
    
    public override void InstallBindings()
    {
        Container.BindInstance(_itemIconAsset).AsSingle();
        Container.BindInterfacesTo<ItemIconProvider>().AsSingle();
        Container.BindInterfacesTo<ItemFactory>().AsSingle();
    }
}

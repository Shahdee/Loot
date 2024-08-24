using Zenject;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemInstaller", menuName = "SO/Zenject/ItemInstaller")]
public class ItemInstaller : ScriptableObjectInstaller
{
    [SerializeField] private ItemIconAsset _itemIconAsset;
    [SerializeField] private ItemStatAsset _itemStatAsset;
    
    public override void InstallBindings()
    {
        Container.BindInstance(_itemIconAsset).AsSingle();
        Container.BindInstance(_itemStatAsset).AsSingle();
        
        Container.BindInterfacesTo<ItemIconProvider>().AsSingle();
        Container.BindInterfacesTo<ItemFactory>().AsSingle();
        Container.BindInterfacesTo<ItemStatDataProvider>().AsSingle();
        Container.BindInterfacesTo<ItemStatFormatController>().AsSingle();
    }
}

using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "WindowInstaller", menuName = "SO/Zenject/WindowInstaller")]
public class WindowInstaller : ScriptableObjectInstaller<WindowInstaller>
{
    [SerializeField] private MainWindowView _mainWindowView;
    [SerializeField] private DropWindowView _dropWindowView;
    [SerializeField] private ItemStatWindowView _itemStatWindowView;
    
    [SerializeField] private WindowParentView _windowParentView;

    public override void InstallBindings()
    {
        BindWindows();
    }

    private void BindWindows()
    {
        BindAsset(_mainWindowView);
        BindAsset(_dropWindowView);
        BindAsset(_itemStatWindowView);
        BindAsset(_windowParentView);
        
        Container.BindInterfacesTo<MainWindow>().AsSingle();
        Container.BindInterfacesTo<DropWindow>().AsSingle();
        Container.BindInterfacesTo<ItemStatWindow>().AsSingle();
        
        
        Container.BindInterfacesTo<WindowStorage>().AsSingle();
        Container.BindInterfacesTo<WindowController>().AsSingle();
        Container.BindInterfacesTo<WindowParent>().AsSingle().NonLazy();
    }

    private void BindAsset<T>(T prefab) where T : MonoBehaviour
    {
        Container.Bind<T>().FromComponentInNewPrefab(prefab).AsSingle();
    }
}

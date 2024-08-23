using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<GameManager>().AsSingle();
        Container.BindInterfacesTo<GamePlayMediator>().AsSingle().NonLazy();
    }
}

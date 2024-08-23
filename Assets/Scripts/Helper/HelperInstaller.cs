using Zenject;


    public class HelperInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<UnityEventController>().AsSingle();
        }
    }

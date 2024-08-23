using UnityEngine;
using Zenject;

namespace Character
{
    [CreateAssetMenu(fileName = "CharacterInstaller", menuName = "SO/Zenject/CharacterInstaller")]
    public class CharacterInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private CharacterView _characterView;
        
        public override void InstallBindings()
        {
            BindAsset(_characterView); 
            
            Container.BindInterfacesTo<CharacterController>().AsSingle();
            Container.BindInterfacesTo<CharacterModel>().AsSingle();
        }
        
        
        private void BindAsset<T>(T prefab) where T : MonoBehaviour
        {
            Container.Bind<T>().FromComponentInNewPrefab(prefab).AsSingle();
        }
    }
}
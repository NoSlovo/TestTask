using UnityEngine;
using Сreators;

namespace DefaultNamespace
{
    public class EmergencePoint : MonoBehaviour
    {
        [SerializeField] private CharacterCreator _characterCreator;

        private void Start() => CreateCharacter();

        public void CreateCharacter() =>  _characterCreator.Create();
        
    }
}
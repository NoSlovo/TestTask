using System;
using DefaultNamespace.EntryPoint;
using Player;
using UnityEngine;
using Сreators;

namespace DefaultNamespace
{
    public class EmergencePoint : MonoBehaviour
    {
        [SerializeField] private Character _characterPrefab;

        private CreatorService _creatorService;
        
        public Action<Character> OnCharacterCreated;

        private void Start()
        {
            _creatorService = ServiceLocator.Instance.GetService<CreatorService>();
            CreateCharacter();
        }


        public void CreateCharacter()
        {
           Character character = _creatorService.Create(_characterPrefab);
           OnCharacterCreated?.Invoke(character);
        } 

    }
}
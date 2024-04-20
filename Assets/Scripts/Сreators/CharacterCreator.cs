using System;
using Player;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Сreators
{
    [Serializable]
    public class CharacterCreator : ICreatorService<Character>
    {
        [field: SerializeField] private Character _characterPrefab;

        public CharacterCreator(Character characterPrefab) => _characterPrefab = characterPrefab;

        public override Character Create() => Object.Instantiate(_characterPrefab);
    }
}
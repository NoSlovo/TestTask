using ShootingGallery;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace.Level
{
    public class LevelProvider : MonoBehaviour
    {
        [SerializeField] private Encounter[] _encounters;
        [SerializeField] private Transform _characterSpawnPosition;
        
        public Encounter[] GetEncounters() => _encounters;
        public Transform GetCharacterSpawnPosition() => _characterSpawnPosition;
    }
}
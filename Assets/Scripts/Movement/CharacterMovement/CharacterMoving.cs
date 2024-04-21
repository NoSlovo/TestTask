using DefaultNamespace;
using ShootingGallery;
using UnityEngine;
using Character = Player.Character;

namespace Movement
{
    public class CharacterMoving : MonoBehaviour
    {
        [SerializeField] private ShootingZone[] _shootingZone;
        [SerializeField] private EmergencePoint _emergencyPoints;

        private int _indexZone;

        public void OnEnable() => _emergencyPoints.OnCharacterCreated += Move;

        private void Move(Character character)
        {
            if (_indexZone >= _shootingZone.Length)
                _indexZone = _shootingZone.Length;

            character.MovementComponent.NavMeshAgent.SetDestination(_shootingZone[_indexZone].EntryPoint.position);
        }


        public void OnDisable() => _emergencyPoints.OnCharacterCreated -= Move;
    }
}
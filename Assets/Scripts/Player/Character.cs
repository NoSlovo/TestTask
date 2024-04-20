using Movement;
using UnityEngine;

namespace Player
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private MovementComponent _movementComponent;

        public void Move(Vector3 movePoint) => _movementComponent.NavMeshAgent.SetDestination(movePoint);
    }
}
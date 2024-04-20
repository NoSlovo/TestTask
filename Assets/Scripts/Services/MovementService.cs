using Services;
using UnityEngine;

namespace Movement
{
    public class MovementService : IService
    {
        public void Move(MovementComponent component, Vector3 destination) =>
            component.NavMeshAgent.SetDestination(destination);
    }
}
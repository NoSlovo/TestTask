using UnityEngine;
using UnityEngine.AI;

namespace Movement
{
    [System.Serializable]
    public class MovementComponent
    {
        [field: SerializeField] public NavMeshAgent NavMeshAgent { get; private set; }
    }
}
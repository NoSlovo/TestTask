using Movement;
using UnityEngine;

namespace Player
{
    public class Character : MonoBehaviour
    {
        [field:SerializeField] public MovementComponent MovementComponent { get;private set; }
    }
}
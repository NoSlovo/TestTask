using Services;
using UnityEngine;

namespace Movement
{
    public class MovementService : IService
    {
        private MovementComponent _character;
        private Vector3[] _waypoints;

        private int _indexZone;

        public MovementService(MovementComponent character, Vector3[] waypoints)
        {
            _waypoints = waypoints;
            _character = character;
        }

        public void MoveToNextPoint()
        {
            _indexZone++;
            _character.NavMeshAgent.SetDestination(_waypoints[_indexZone]);
        }
        
        public bool IsLastPoint() => _indexZone == _waypoints.Length - 1;
    }
}
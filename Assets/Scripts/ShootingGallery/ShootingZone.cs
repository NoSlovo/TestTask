using System.Collections.Generic;
using UnityEngine;

namespace ShootingGallery
{
    public class ShootingZone : MonoBehaviour
    {
        [SerializeField] private List<Transform> _enemyCreatePoints;
        [SerializeField] private EnemyCreatorService enemyCreatorService;

        [field: SerializeField] public Transform EntryPoint { get; private set; }

        private List<Enemy> _enemiesinstance;

        private int _countingDeadEnemies = 0;

        public void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            _enemiesinstance = new List<Enemy>(_enemyCreatePoints.Count);
            for (int i = 0; i < _enemyCreatePoints.Count; i++)
            {
                Enemy enemy = enemyCreatorService.Create();
                enemy.transform.position = _enemyCreatePoints[i].position;
                _enemiesinstance.Add(enemy);
            }
        }

        public void AddDeadEnemy()
        {
            _countingDeadEnemies++;
            CheckDeadAllEnemies();
        }

        private void CheckDeadAllEnemies()
        {
            if (_countingDeadEnemies >= _enemiesinstance.Count)
            {
            }
        }
    }
}
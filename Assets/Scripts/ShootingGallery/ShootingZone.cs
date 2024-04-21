using System.Collections.Generic;
using System.Linq;
using DefaultNamespace.EntryPoint;
using UnityEngine;
using Сreators;

namespace ShootingGallery
{
    public class ShootingZone : MonoBehaviour
    {
        [SerializeField] private List<Transform> _enemyCreatePoints;
        [SerializeField] private Enemy _enemyPrefab;

        [field: SerializeField] public Transform EntryPoint { get; private set; }


        private CreatorService _enemyCreatorService;
        private List<Enemy> _enemiesInstance;

        private int _countingDeadEnemies = 0;

        public void Start()
        {
            _enemyCreatorService = ServiceLocator.Instance.GetService<CreatorService>();
            Setup();
        }

        private void Setup()
        {
            _enemiesInstance = new List<Enemy>(_enemyCreatePoints.Count());
            for (int i = 0; i < _enemyCreatePoints.Count; i++)
            {
                Enemy enemy = _enemyCreatorService.Create(_enemyPrefab);
                enemy.transform.position = _enemyCreatePoints[i].position;
                _enemiesInstance.Add(enemy);
            }
        }

        public void AddDeadEnemy()
        {
            _countingDeadEnemies++;
            CheckDeadAllEnemies();
        }

        private void CheckDeadAllEnemies()
        {
            if (_countingDeadEnemies >= _enemiesInstance.Count)
            {
            }
        }
    }
}
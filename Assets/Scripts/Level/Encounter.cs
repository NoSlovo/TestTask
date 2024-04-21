using System;
using System.Collections.Generic;
using UnityEngine;

namespace ShootingGallery
{
    public class Encounter : MonoBehaviour, IDisposable //TODO : Rename -> ENCOUNTER
    {
        [SerializeField] private List<Transform> _enemyCreatePoints;
        [SerializeField] private Enemy _enemyPrefab;
        
        public Action OnEncounterCompleted;

        [field: SerializeField] public Transform EntryPoint { get; private set; }

        private List<Enemy> _enemyInstances;
        private int _countingDeadEnemies = 0;

        public void Setup()
        {
            _enemyInstances = new List<Enemy>(_enemyCreatePoints.Count);
            for (var i = 0; i < _enemyCreatePoints.Count; i++)
            {
                var enemy = Instantiate(_enemyPrefab);
                enemy.transform.position = _enemyCreatePoints[i].position;
                _enemyInstances.Add(enemy);
            }
        }

        public void AddDeadEnemy()
        {
            _countingDeadEnemies++;
            if(!IsFinished())
                return;
            OnEncounterCompleted?.Invoke();
        }

        public bool IsFinished() => _countingDeadEnemies == _enemyInstances.Count;

        public void Dispose()
        {
            //написать код
        }
    }
}
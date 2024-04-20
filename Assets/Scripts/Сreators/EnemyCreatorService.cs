using System;
using UnityEngine;
using Сreators;
using Object = UnityEngine.Object;

[Serializable]
public class EnemyCreatorService : ICreatorService<Enemy>
{
    [field: SerializeField] private Enemy _enemyPrefab;

    public EnemyCreatorService(Enemy enemyPrefab) => _enemyPrefab = enemyPrefab;

    public override Enemy Create() => Object.Instantiate(_enemyPrefab);
}
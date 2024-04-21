using DefaultNamespace.EntryPoint;
using Movement;
using UnityEngine;
using Сreators;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private GameObject _levelPrefab;
    
    private static ServiceLocator _locator => ServiceLocator.Instance;

    public void Start()
    {
        ServiceLocator.Init();
        RegisterServices();
        InitLevel();
    }

    private void RegisterServices()
    {
        _locator.RegisterService<MovementService>(new MovementService());
        _locator.RegisterService<CreatorService>(new CreatorService());
    }

    private void InitLevel()
    {
        //LevelService.CreateLevel();
    }
}
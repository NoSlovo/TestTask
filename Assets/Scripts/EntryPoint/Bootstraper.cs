using DefaultNamespace.EntryPoint;
using UnityEngine;

public class Bootstraper : MonoBehaviour
{
   
   private void Initialize()
   {
    ServiceLocator.Instance.Init();
   }
}

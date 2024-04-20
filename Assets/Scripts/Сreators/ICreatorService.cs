using UnityEngine;

namespace Сreators
{
    public abstract class ICreatorService<T> where T : MonoBehaviour
    {
        public abstract T Create();
    }
}
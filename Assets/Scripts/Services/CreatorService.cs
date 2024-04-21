using System;
using Services;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Сreators
{
    [Serializable]
    public  class CreatorService : IService
    {
        public T Create<T>(T creatObject) where T : MonoBehaviour =>  Object.Instantiate(creatObject);
    }
}
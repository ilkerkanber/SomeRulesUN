using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Abstracts.Singletons
{
    public abstract class SingletonSetup<T> : MonoBehaviour
    {
        //T ile gelenden static property oluþturduk.
        public static T Instance { get; private set; }

        protected void Setup(T targetClass)
        {
            if (Instance == null)
            {
                Instance = targetClass;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}

using Game.Abstracts.Singletons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Managers
{
    public class PlayerManager:SingletonSetup<PlayerManager>
    {
        public event System.Action EventPlayerAttack;
        public event System.Action EventPlayerDead;

        void Awake()
        {
            Setup(this);
        }
        public void PlayerAttack()
        {
            EventPlayerAttack?.Invoke();
        }
        public void PlayerDead() 
        {
            EventPlayerDead?.Invoke();
        }
    }

}

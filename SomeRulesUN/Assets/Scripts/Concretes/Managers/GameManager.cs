using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Abstracts.Singletons;

namespace Game.Concretes.Managers
{
    public class GameManager : SingletonSetup<GameManager>
    {
        public event System.Action EventGameOver;
        public event System.Action EventWinGame;
        void Awake()
        {
            Setup(this);
        }
        public void GameOver()
        {
            EventGameOver?.Invoke();
        }
        public void WinGame()
        {
            EventWinGame?.Invoke();
        }
        public void StopGame()
        {
            Time.timeScale = 0;
        }
        public void ResumeGame()
        {
            Time.timeScale = 1;
        }

    }

}

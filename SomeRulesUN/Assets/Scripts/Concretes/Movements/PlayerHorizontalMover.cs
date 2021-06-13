using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class PlayerHorizontalMover
    {
        PlayerController _playerController;
        float speed;
        
        public PlayerHorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
            speed = _playerController.HorizontalSpeed;
        }
        public void HorMove()
        {
            _playerController.transform.Translate(-Vector3.right * Time.deltaTime * speed);
        }
    }
}


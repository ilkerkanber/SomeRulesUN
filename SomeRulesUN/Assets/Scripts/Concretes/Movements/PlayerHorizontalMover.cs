using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class PlayerHorizontalMover
    {
        PlayerController _playerController;        
        public PlayerHorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void HorMove(float speed)
        {
            speed = _playerController.HorizontalSpeed;
            _playerController.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}


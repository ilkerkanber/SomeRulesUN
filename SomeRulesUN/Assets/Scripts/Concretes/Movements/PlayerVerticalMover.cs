using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class PlayerVerticalMover 
    {
        PlayerController _playerController;
        public PlayerVerticalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        internal void Left(float speed)
        {
            _playerController.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        internal void Right(float speed)
        {
            _playerController.transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
    }
}


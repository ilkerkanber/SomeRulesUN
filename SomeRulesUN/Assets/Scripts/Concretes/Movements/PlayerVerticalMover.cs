using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class PlayerVerticalMover 
    {
        PlayerController _playerController;
        float distance = 5f;
        public PlayerVerticalMover(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void Left()
        {
            _playerController.transform.Translate(Vector3.forward * Time.deltaTime * distance);
        }
        public void Right()
        {
            _playerController.transform.Translate(-Vector3.forward * Time.deltaTime * distance);
        }
    }
}


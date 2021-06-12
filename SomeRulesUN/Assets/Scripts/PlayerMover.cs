using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Movements {
    public class PlayerMover : MonoBehaviour
    {
        PlayerController _playerController;
        public PlayerMover(PlayerController pl)
        {
            _playerController = pl;
        }
       
    }
}


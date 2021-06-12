using Game.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers {
    public class PlayerController : MonoBehaviour
    {
        PlayerMover _playerMover;
        
        void Awake()
        {
            _playerMover = new PlayerMover(this);
        }

    }

}

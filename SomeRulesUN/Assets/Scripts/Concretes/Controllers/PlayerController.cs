using Game.Abstracts.Inputs;
using Game.Concretes.Movements;
using UnityEngine;

namespace Game.Concretes.Controllers {
    public class PlayerController : PlayerInput
    {   
        PlayerHorizontalMover _playerHorizontalMover;
        PlayerVerticalMover _playerVerticalMover;

        [SerializeField] float horizontalSpeed=2f;

        public float HorizontalSpeed => horizontalSpeed;

        void Awake()
        {
            _playerHorizontalMover = new PlayerHorizontalMover(this);
            _playerVerticalMover = new PlayerVerticalMover(this);
        }
        void Update()
        {
            KeyController();
        }
        void FixedUpdate()
        {
            _playerHorizontalMover.HorMove();

            if (LeftKeyPressed) 
            {
                _playerVerticalMover.Left();
            }
            if (RightKeyPressed)
            {
                _playerVerticalMover.Right();
            }
            
        }
    }

}

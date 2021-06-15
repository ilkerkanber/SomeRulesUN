using Game.Abstracts.Inputs;
using Game.Animations;
using Game.Concretes.Movements;
using UnityEngine;

namespace Game.Concretes.Controllers {
    public class PlayerController : PlayerInput
    {   
        PlayerHorizontalMover _playerHorizontalMover;
        PlayerVerticalMover _playerVerticalMover;
        AnimatorController _animatorController;
        
        [field: SerializeField]
        public float HorizontalSpeed { get; private set; }

        [field: SerializeField]
        public float VerticalSpeed { get; private set; }
      
        void Awake()
        {
            _animatorController = new AnimatorController(this);
            _playerHorizontalMover = new PlayerHorizontalMover(this);
            _playerVerticalMover = new PlayerVerticalMover(this);
        }
        void Update()
        {
            KeyController();
        }
        void FixedUpdate()
        {
            _playerHorizontalMover.HorMove(HorizontalSpeed);

            if (LeftKeyPressed) 
            {
                _playerVerticalMover.Left(VerticalSpeed);
            }
            if (RightKeyPressed)
            {
                _playerVerticalMover.Right(VerticalSpeed);
            }
        }
      
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag=="Enemy")
            {
                IsDead();
            }
        }
        void IsDead()
        {
            VerticalSpeed = 0;
            HorizontalSpeed = 0;
            _animatorController.PlayerDeadAnim();
        }


    }

}

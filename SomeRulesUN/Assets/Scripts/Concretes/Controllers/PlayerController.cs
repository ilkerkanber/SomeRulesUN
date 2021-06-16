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

        void OnEnable()
        {
            GameManager.Instance.EventGameOver += Dead;   
        }
        void OnDisable()
        {
            GameManager.Instance.EventGameOver -= Dead;
        }
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
      
        void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("EnemyBody"))
            {
                GameManager.Instance.GameOver();
            }
        }
        void Dead()
        {
            VerticalSpeed = 0;
            HorizontalSpeed = 0;
            _animatorController.PlayerDeadAnim();
        }

    }

}

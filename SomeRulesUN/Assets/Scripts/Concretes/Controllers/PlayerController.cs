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
        CollisionController _raycastController;

        [field:SerializeField]
        public float RayDistance { get; private set; }

        [field: SerializeField]
        public float HorizontalSpeed { get; private set; }

        [field: SerializeField]
        public float VerticalSpeed { get; private set; }

        void OnEnable()
        {
            GameManager.Instance.EventGameOver += Dead;
            GameManager.Instance.EventPlayerAttack += Attack;
        }
        void OnDisable()
        {
            GameManager.Instance.EventGameOver -= Dead;
            GameManager.Instance.EventPlayerAttack -= Attack;
        }
        void Awake()
        {
            _animatorController = new AnimatorController(this);
            _playerHorizontalMover = new PlayerHorizontalMover(this);
            _playerVerticalMover = new PlayerVerticalMover(this);
            _raycastController = new CollisionController(this);
        }
        void Update()
        {
            _raycastController.CollisionControl();
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
        void Attack()
        {
            _animatorController.PlayerAttackAnim();
        }
        void Dead()
        {
            VerticalSpeed = 0;
            HorizontalSpeed = 0;
            _animatorController.PlayerDeadAnim();
        }

    }

}

using Game.Abstracts.Inputs;
using Game.Animations;
using Game.Concretes.Managers;
using Game.Concretes.Movements;
using UnityEngine;

namespace Game.Concretes.Controllers {
    public class PlayerController : PlayerInput
    {   
        PlayerHorizontalMover _playerHorizontalMover;
        PlayerVerticalMover _playerVerticalMover;
        AnimatorController _animatorController;
        CollisionController _raycastController;

        public bool IsDead { get; set; }
        public bool IsAttack { get; set; }

        [field:SerializeField]
        public float RayDistance { get; private set; }

        [field: SerializeField]
        public float HorizontalSpeed { get; private set; }

        [field: SerializeField]
        public float VerticalSpeed { get; private set; }
        void Awake()
        {
            _animatorController = new AnimatorController(this);
            _playerHorizontalMover = new PlayerHorizontalMover(this);
            _playerVerticalMover = new PlayerVerticalMover(this);
            _raycastController = new CollisionController(this);
        }
        void Start()
        {
            PlayerManager.Instance.EventPlayerAttack += Attack;
            PlayerManager.Instance.EventPlayerDead += Dead;
        }
        void OnDisable()
        {
            PlayerManager.Instance.EventPlayerAttack -= Attack;
            PlayerManager.Instance.EventPlayerDead -= Dead;

        }
      
        void Update()
        {
            _raycastController.CollisionControl();
            KeyController();
            if (IsAttack)
            {
                PlayerManager.Instance.PlayerAttack();
                IsAttack = false;
            }
            if (IsDead)
            {
                PlayerManager.Instance.PlayerDead();
            }
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

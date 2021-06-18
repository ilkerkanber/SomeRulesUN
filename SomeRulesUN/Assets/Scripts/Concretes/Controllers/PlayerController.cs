using Game.Abstracts.Inputs;
using Game.Animations;
using Game.Concretes.Managers;
using Game.Concretes.Movements;
using Game.Abstracts.Movements;
using UnityEngine;
using Game.Abstracts.Controllers;

namespace Game.Concretes.Controllers {
    public class PlayerController : PlayerInput,IEntityController
    {   
        IHorizontalMover _IhorizontalMover;
        IVerticalMover _IverticalMover;
        AnimatorController _animatorController;
        CollisionController _collisionController;

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
            _IhorizontalMover = new PlayerHorizontalMover(this);
            _IverticalMover = new PlayerVerticalMover(this);
            _collisionController = new CollisionController(this);
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
            _collisionController.CollisionControl();
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
            _IhorizontalMover.HorMove(HorizontalSpeed);

            if (LeftKeyPressed) 
            {
                _IverticalMover.Left(VerticalSpeed);
            }
            if (RightKeyPressed)
            {
                _IverticalMover.Right(VerticalSpeed);
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

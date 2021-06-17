using Game.Concretes.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Animations {
    public class AnimatorController
    {
        PlayerController _playerController;
        Animator animator;
        public AnimatorController(PlayerController playerController)
        {
            _playerController = playerController;
            animator = playerController.GetComponent<Animator>();
        }
        
        internal void PlayerDeadAnim()
        {
            animator.SetTrigger("IsDead");
        }
        internal void PlayerAttackAnim()
        {
           // _playerController.IsAttack = false;
            
        }

    }
}


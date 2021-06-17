using Game.Concretes.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Animations {
    public class AnimatorController
    {
        Animator animator;
        float AnimationRespawnTime = 1f;
        float waitTime;
        public AnimatorController(PlayerController playerController)
        {
            animator = playerController.GetComponent<Animator>();
        }
        
        public void PlayerDeadAnim()
        {
            animator.SetTrigger("IsDead");
        }
        public void PlayerAttackAnim()
        {
            if (Time.time - waitTime > AnimationRespawnTime) {
                waitTime = Time.time;
                animator.SetTrigger("IsAttack");
                animator.SetTrigger("IsRun");
            }
           
        }
    }
}


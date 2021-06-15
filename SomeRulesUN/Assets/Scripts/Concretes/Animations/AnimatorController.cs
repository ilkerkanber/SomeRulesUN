using Game.Concretes.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Animations {
    public class AnimatorController : MonoBehaviour
    {
        PlayerController _playerController;
        Animator animator;
        public AnimatorController(PlayerController playerController)
        {
            _playerController = playerController;
            animator = playerController.GetComponent<Animator>();
        }
       public void PlayerDeadAnim()
        {
            animator.SetTrigger("IsDead");
        }

    }
}


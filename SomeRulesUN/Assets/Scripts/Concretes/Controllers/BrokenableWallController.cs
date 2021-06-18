using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Controllers {
    public class BrokenableWallController : MonoBehaviour
    {
        Animator animator;
        void Start()
        {
            animator = GetComponent<Animator>();
        }
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("BrokenCollision");
            animator.SetTrigger("Broken");
        }
    }
}


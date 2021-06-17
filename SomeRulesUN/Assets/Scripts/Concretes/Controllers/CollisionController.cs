using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public class CollisionController
    {
        RaycastHit targetObject;
        PlayerController _playerController;
        Vector3 playerPos;
        float rayDistance;
        public CollisionController(PlayerController playerController)
        {
            _playerController = playerController;
            rayDistance = _playerController.RayDistance;
        }
        public void CollisionControl()
        {
            playerPos = _playerController.transform.position;

            //SALDIRMA
            if (Physics.Raycast(playerPos, Vector3.right, out targetObject, rayDistance))
            {
                Debug.Log(rayDistance);
                if(targetObject.collider.gameObject.tag == "Brokenable")
                {
                    Debug.Log("EnemyBody collision:Attack");

                    _playerController.IsAttack = true;
                }
            }
            //ÇARPIÞMA
            if (Physics.Raycast(playerPos, Vector3.right, out targetObject, 1f))
            {
                if (targetObject.collider.gameObject.tag == "EnemyBody")
                {
                    Debug.Log("EnemyBody collision:Dead");
                    _playerController.IsDead = true;
                }
            }


           
        }

    }
}
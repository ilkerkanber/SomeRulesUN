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

            if (Physics.Raycast(playerPos, Vector3.right, out targetObject, rayDistance))
            {
                if(targetObject.collider.gameObject.tag == "EnemyBody")
                {
                    GameManager.Instance.PlayerAttack();
                }
            }
            if (Physics.Raycast(playerPos, Vector3.right, out targetObject, 1f))
            {
                if (targetObject.collider.gameObject.tag == "EnemyBody")
                {
                    GameManager.Instance.GameOver();
                }
            }


           
        }

    }
}
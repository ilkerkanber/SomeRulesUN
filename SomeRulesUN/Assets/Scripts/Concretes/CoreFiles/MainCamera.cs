using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.CoreFiles
{
    public class MainCamera : MonoBehaviour
    {
        [SerializeField] GameObject watchGameObject;

        [Range(-15, 15)]
        [SerializeField] float xDistance, yDistance;
        [Range(-10, 10)]
        [SerializeField] float zDistance;
        [Range(0, 180)]
        [SerializeField] float xRotate, yRotate, zRotate;
        void FixedUpdate()
        {
            float x = watchGameObject.transform.position.x;
            float y = watchGameObject.transform.position.y;
            float z = watchGameObject.transform.position.z;
            transform.rotation = Quaternion.Euler(xRotate, yRotate, zRotate);
            transform.position = new Vector3(x + xDistance, y + yDistance, z + zDistance);
        }
    }

}

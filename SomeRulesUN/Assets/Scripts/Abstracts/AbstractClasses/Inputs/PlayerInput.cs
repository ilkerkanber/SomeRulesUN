using UnityEngine;

namespace Game.Abstracts.Inputs
{
    public abstract class PlayerInput : MonoBehaviour
    {
        protected bool LeftKeyPressed  { get; private set; }
        protected bool RightKeyPressed { get; private set; }
        protected void KeyController() {

            if (Input.GetKey(KeyCode.A))
            {
                LeftKeyPressed = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                RightKeyPressed = true;
            }
            else
            {
                LeftKeyPressed = false;
                RightKeyPressed = false;
            }
        }
        
    }
}


using Game.Abstracts.Controllers;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class PlayerVerticalMover:IVerticalMover
    {
        IEntityController _IentityController;
        public PlayerVerticalMover(IEntityController entityController)
        {
            _IentityController = entityController;
        }
        public void Left(float speed)
        {
            _IentityController.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        public void Right(float speed)
        {
            _IentityController.transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
    }
}


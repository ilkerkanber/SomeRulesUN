using Game.Abstracts.Controllers;
using Game.Abstracts.Movements;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class VerticalMover:IVerticalMover
    {
        IEntityController _IentityController;
        public VerticalMover(IEntityController entityController)
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


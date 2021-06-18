using Game.Abstracts.Controllers;
using Game.Abstracts.Movements;
using Game.Concretes.Controllers;
using UnityEngine;

namespace Game.Concretes.Movements {
    public class HorizontalMover: IHorizontalMover
    {
        IEntityController _IentityController;        
        public HorizontalMover(IEntityController entityController)
        {
            _IentityController = entityController;
        }
        public void HorMove(float speed)
        {
            _IentityController.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}


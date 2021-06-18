using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Abstracts.Movements {
    public interface IVerticalMover
    {
        void Left(float speed);
        void Right(float speed);
    }
}


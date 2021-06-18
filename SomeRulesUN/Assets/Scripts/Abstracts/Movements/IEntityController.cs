using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Abstracts.Controllers{
    public interface IEntityController
    {
        Transform transform { get; }
        float HorizontalSpeed { get; }
        float VerticalSpeed { get; }
    
    }
}


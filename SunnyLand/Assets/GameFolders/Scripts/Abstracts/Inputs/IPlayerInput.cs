using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Abstracts.Inputs
{
    public interface IPlayerInput 
    {
        float Horizontal { get;  }
        bool Jump { get;  }
    }
}


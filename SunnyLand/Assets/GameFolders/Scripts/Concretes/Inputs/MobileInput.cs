using SecondGame.Abstracts.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Inputs
{
    public class MobileInput : IPlayerInput
    {
        public float Horizontal => Input.GetAxis("Horizontal");

        public bool Jump => Input.GetButtonDown("Jump");
    }
}


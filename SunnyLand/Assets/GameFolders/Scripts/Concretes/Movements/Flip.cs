using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Movements
{
    public class Flip : MonoBehaviour
    {
       

        public void FlipAction (float _horizontal) 
        {
            float signHorizontal= Mathf.Sign(_horizontal);

            if (_horizontal != 0f)
            {
                transform.localScale = new Vector3(signHorizontal, 1f, 1f);
            }
        }
    }

}

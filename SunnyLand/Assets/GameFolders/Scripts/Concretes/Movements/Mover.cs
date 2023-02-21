using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Movements
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] float _speed = 10f;
        public void MoveAction(float horizontal)
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed * horizontal);

            
        }
    }
}


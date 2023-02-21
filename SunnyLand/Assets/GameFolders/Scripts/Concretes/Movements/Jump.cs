using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jump : MonoBehaviour
    {
        bool _isJump;
        float _jumpforce = 350f;

        Rigidbody2D _rigidbody2D;

        public bool IsJump => _rigidbody2D.velocity != Vector2.zero;
        public bool IsJumpButtonPress
        {
            get { return _isJump; }
            set { _isJump = value; }
        }

        private void Awake()
        {
            _rigidbody2D= GetComponent<Rigidbody2D>();
        }

       
        public void JumpAction()
        {
            if (IsJump) return;
            if (_isJump)
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpforce);
                _isJump = false;

            }
        }
    }
}


using SecondGame.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Animations
{
    [RequireComponent(typeof(Animator))]
    public class CharacterAnimation : MonoBehaviour
    {
        Animator _animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }
        public void MoveSpeedSet(float _horizontal)
        {
            float absluteHorizontal = Mathf.Abs(_horizontal);
            _animator.SetFloat("moveSpeed", absluteHorizontal);
        }
        public void IsJumpSet( bool isJump )
        {
            _animator.SetBool("isJump", isJump);
        }


    }
}


using SecondGame.Abstracts.Inputs;
using SecondGame.Animations;
using SecondGame.Inputs;
using SecondGame.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SecondGame.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        
        [SerializeField] float _horizontal;
        
        Mover _mover;
        Jump _jump;
        CharacterAnimation _characterAnimation;
        Flip _flip;
        IPlayerInput _input;
        
        private void Awake()
        {
            _characterAnimation= GetComponent<CharacterAnimation>();
            _jump= GetComponent<Jump>();
            _mover= GetComponent<Mover>();
            _flip = GetComponent<Flip>();
            _input = new PcInput();
        }
       
        private void Update()
        {
            _horizontal = _input.Horizontal;

            if (_input.Jump) _jump.IsJumpButtonPress = true;
           
            _characterAnimation.MoveSpeedSet(_horizontal);
            _characterAnimation.IsJumpSet(_jump.IsJump);
           
        }
        private void FixedUpdate()
        {
            _flip.FlipAction(_horizontal);
            _mover.MoveAction(_horizontal);

            _jump.JumpAction();
            
        }

        
    }

}

using System;
using Input;
using UnityEngine;

namespace Player
{
    public class PlayerController: MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Vector2 _movementInput;
        private GameManager _gameManager;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _gameManager = GameManager.Instance;
            Debug.Log(_gameManager);
        }

        private void Update()
        {
            _movementInput = InputManager.Instance.PlayerInput.Movement.Get();
        }

        private void FixedUpdate()
        {
            _rigidbody2D.linearVelocity = _movementInput * _gameManager.PlayerSetting.MoveSpeed ;
        }

        
    }
}
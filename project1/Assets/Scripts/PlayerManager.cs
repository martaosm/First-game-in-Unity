using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private float _moveSpeed = 5.0f;

    private float _jump = 10.0f;

    private bool _faceRigth = true;

    private bool _isOnGround = false;
    private LayerMask _groundMask;
    private Transform _groundChecker;
    private float _checkRadius;

    private Animator _animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _groundMask = LayerMask.GetMask("Ground");
        _groundChecker = transform.Find("GroundChecker");
        _checkRadius = 0.5f;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float inputValue = Input.GetAxisRaw("Horizontal");
        if (inputValue > 0.0f)
        {
            //prawo
            _rigidbody.velocity = new Vector2(_moveSpeed,_rigidbody.velocity.y);
            if (_faceRigth != true)
            {
                _faceRigth = true;
                FlipPlayer();
            }
        }
        else if(inputValue < 0.0f)
        {
            //lewo
            _rigidbody.velocity = new Vector2(-_moveSpeed, _rigidbody.velocity.y);
            if (_faceRigth == true)
            {
                _faceRigth = false;
                FlipPlayer();
            }
        }
        else
        {
            //stoj
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);
        }
        
        _isOnGround = Physics2D.OverlapCircle(_groundChecker.position, _checkRadius, _groundMask);

        if (_isOnGround)
        {
            _animator.SetFloat("Speed",Mathf.Abs(inputValue));
        }
        

    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && _isOnGround)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
        }
        _isOnGround = Physics2D.OverlapCircle(_groundChecker.position, _checkRadius, _groundMask);
        _animator.SetBool("Jumping", !_isOnGround);
    }

    void FlipPlayer()
    {
        transform.Rotate(0.0f, 180.0f, 0.0f);
    }
}

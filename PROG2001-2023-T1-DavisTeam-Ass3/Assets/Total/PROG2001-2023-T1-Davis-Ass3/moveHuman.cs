using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHuman : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody _rb;

    public static float walkSpeed = 3f;
    public float runSpeed;

    private float _currentSpeed;
    private float _horizontal;
    private float _vertical;

    private Vector3 _direction;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _direction = new Vector3(_horizontal, 0, _vertical).normalized;
        if (_direction.magnitude > 0f)
        {
            // Get the rotation to look at from the input direction
            Quaternion targetRotation = Quaternion.LookRotation(new Vector3(_horizontal, 0f, _vertical), Vector3.up);

            // Smoothly rotate the character towards the target rotation
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 20f);

            // Move the character in the direction of the input at the set speed
            Vector3 p = transform.position;
            p += _direction * walkSpeed * Time.deltaTime;
            _rb.MovePosition(p);
        }

        _currentSpeed = new Vector3(_horizontal, 0, _vertical).magnitude;
        _animator.SetFloat("walkSpeed", _currentSpeed);
    }
}
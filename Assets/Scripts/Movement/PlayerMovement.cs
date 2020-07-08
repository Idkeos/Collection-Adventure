using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 20f;
    public float TurnSpeed = 300f;

    private float MovementInputValue;
    private float TurnInputValue;

    private Rigidbody Rigidbody;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovementInputValue = Input.GetAxis("Vertical");
        TurnInputValue = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Turn();
        Move();
    }

    private void Move()
    {
        Vector3 movement = transform.forward * MovementInputValue * Speed * Time.deltaTime;

        Rigidbody.MovePosition(Rigidbody.position + movement);
    }

    private void Turn()
    {
        float turn = TurnInputValue * TurnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        Rigidbody.MoveRotation(Rigidbody.rotation * turnRotation);
    }
}

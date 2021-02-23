using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class AgentMovement : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    [field: SerializeField]
    public MovementDataSO MovementData { get; set; }

    [SerializeField]
    public float currentVelocity = 3;

    protected Vector2 movementDirection;

    [field: SerializeField]
    public UnityEvent<float> OnVelocityChange { get; set; }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void MoveAgent(Vector2 movementInput)
    {
        movementDirection = movementInput;
        currentVelocity = CalculateSpeed(movementInput);
    }

    private float CalculateSpeed(Vector2 movementInput)
    {
        if (movementInput.magnitude > 0)
        {
            currentVelocity += MovementData.aceleration * Time.deltaTime;
        }
        else
        {
            currentVelocity -= MovementData.deceleration * Time.deltaTime;
        }
        return Mathf.Clamp(currentVelocity, 0, MovementData.maxSpeed);
    }

    private void FixedUpdate()
    {
        OnVelocityChange?.Invoke(currentVelocity);
        rigidBody.velocity = currentVelocity * movementDirection.normalized;
    }
}

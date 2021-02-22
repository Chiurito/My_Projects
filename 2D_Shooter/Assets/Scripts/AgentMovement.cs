using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class AgentMovement : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    [SerializeField]
    public float currentVelocity = 3;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void MoveAgent(Vector2 movementInput)
    {
        rigidBody.velocity = movementInput.normalized * currentVelocity;
    }
}

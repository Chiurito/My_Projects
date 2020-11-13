using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    private float moveInputH;
    private float moveInputV;
    private Rigidbody rigidB;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rigidB = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        moveInputH = Input.GetAxis("Horizontal");
        moveInputV=  Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rigidB.velocity = new Vector3(moveInputH * moveSpeed, 0f, moveInputV * moveSpeed);
    }
}

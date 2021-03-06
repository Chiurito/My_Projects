using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Transform farBackground, middleBackground;

    public float minHeight, maxHeight;

    private float lastXPos;

    void Start()
    {
        lastXPos = transform.position.x;
    }

    void Update()
    {
        // Move the camera
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        float clampedY = Mathf.Clamp(transform.position.y, minHeight, maxHeight);
        transform.position = new Vector3(transform.position.x, clampedY, 0f);

        // Move layers
        float amountToMoveX = transform.position.x - lastXPos;
        farBackground.position += new Vector3(amountToMoveX, 0f, 0f);
        middleBackground.position += new Vector3(amountToMoveX * 0.5f, 0f, 0f);

        lastXPos = transform.position.x;
    }
}

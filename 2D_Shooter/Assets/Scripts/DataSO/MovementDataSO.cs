using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Agent/MovementData")]
public class MovementDataSO : ScriptableObject
{
    [Range(1, 100)]
    public float maxSpeed = 5;

    [Range(0.1f, 100)]
    public float aceleration = 50, deceleration = 50;
}

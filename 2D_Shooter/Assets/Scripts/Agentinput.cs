using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Agentinput : MonoBehaviour
{
    [SerializeField]
    public UnityEvent<Vector2> OnMovementKeyPressed;

    private void Update()
    {
        GetMovementInput();
    }

    private void GetMovementInput()
    {
        //se c'è qualche oggetto che e' in ascolto su questo evento (segno -> ?) invoca l'evento che in questo
        //caso specifico passa un Vector2

        OnMovementKeyPressed?.Invoke(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")));
    }
}

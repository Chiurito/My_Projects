using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver2 : MonoBehaviour
{
    private void OnEnable()
    {
        Sender.playerDiedInfo += Test2;
    }

    private void OnDisable()
    {
        Sender.playerDiedInfo -= Test2;
    }

    //ESEMPIO 1 NO PARAMETRI
    void Test2()
    {
        print("Called from class Receiver2 and Test2 function no parameters");
    }

    //ESEMPIO 2 CON PARAMETRI
    void Test2(bool alive)
    {
        print("Called from class Receiver2 and Test2 with parameters");
    }
}

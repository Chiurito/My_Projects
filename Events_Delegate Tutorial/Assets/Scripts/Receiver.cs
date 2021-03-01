using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    //Le sottoscrizioni agli eventi si fanno nella funzione OnEnable di Unity.
    //Sottoscrivo la funzione PlayerDiedListener all'ascolto dell'evento (static) playerDiedInfo.
    //In questo modo, quando l'evento viene sollevato, la funzione entra in azione.

    //Gli unsubscrive agli eventi si fanno nella funzione OnDisable quando l'evento termina viene disattivato per prevenire memory leaks

    //PlayerDiedListener() e Test() sono le funzioni che sottoscrivono l'evento (playerDiedInfo) in modo da ricevere l'informazione dall'evento.
    //Quando l'evento viene lanciato queste funzioni vengono eseguite.
    //La funzione che sottoscrive l'evento deve avere la stessa signature del delegato dell'evento.
    //Siccome il delegate è di tipo void, anche questa funzione deve essere di tipo void.


    void Start()
    {
        
    }

    private void OnEnable()
    {
        Sender.playerDiedInfo += PlayerDiedListener;
        //Sender.playerDiedInfo += Test;
    }

    private void OnDisable()
    {
        Sender.playerDiedInfo -= PlayerDiedListener;
        //Sender.playerDiedInfo -= Test;
    }


    /* ESEMPIO 1 SENZA PARAMETRI
    void PlayerDiedListener()
    {
        print("Called from class Receiver and PlayerDiedListener function!");
    }

    void Test()
    {
        print("Called from class Receiver and Test function!");
    }
    */

    // ESEMPIO 2 CON PARAMETRI
    void PlayerDiedListener(bool alive)
    {
        print("Player status IsAlive:" + alive);
    }

}

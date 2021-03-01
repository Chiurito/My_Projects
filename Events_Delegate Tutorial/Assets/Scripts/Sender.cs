using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sender : MonoBehaviour
{
    //il sender informa i subscrivers(receiver) dell'evento;
    //Si dichiara il delegate che serve per sottoscriversi all'evento;
    //Dichiarazione dell'evento basato sul delegate (deve avere lo stesso nome del delegate) che informa i subriscrivers dell'esecuzione dell'evento;
    //Le funzioni che sottoscrivono l'evento devono avere gli stessi parametri dichiarati nel delegate.

    //La dichiarazione dell'evento deve essere STATIC perchè deve poter essere sottoscritto da qualsiasi altra classe esterna a questa.
    //In START si invoca l'esecuzione dell'evento (in questo esempio invoke parte dopo 5 secondi);
    //if (playerDiedInfo != null) controlla se c'è qualche subscriver all'evento. 
    //Se non faccio il controllo e se non ci sono subscrivers, verrà generato un errore.
    //Ci deve essere almeno un subscriver all'evento.
    //Chiama l'evento ed esegue tutte le funzioni di tutte le classi che hanno sottoscritto questo evento.
    //Possono esserci pìù funzioni di classi che hanno sottoscritto questo evento.


    //In questo esempio si può pensare che la classe Sender sia la classe Player e la classe Receiver sia la classe GameManager o 
    //qualsiasi altra classe che debba avere informazioni sul Player.
    //Se il Player muore, viene inviato un evento alla classe GameManager (o qualsiasi altra classe interessata a conoscere info da questa classe)
    //e vengono eseguite le funzioni che sono state sottoscritte a questo evento.


    
    /* ESEMPIO 1 NO PARAMETRI
     * 
    public delegate void PlayerDied();

    public static event PlayerDied playerDiedInfo;

    */

    //ESEMPIO 2 CON PARAMETRI
    public delegate void PlayerDied(bool isAlive);

    public static event PlayerDied playerDiedInfo;

    private bool isAlive;

    void Start()
    {
        Invoke("ExecuteEvent", 3f);
    }

    void ExecuteEvent()
    {
        /*ESEMPIO 1 NO PARAMETRI
         * 
        if (playerDiedInfo != null)
        {
            playerDiedInfo();
        }

        */

        if (playerDiedInfo != null)
        {
            playerDiedInfo(true);
        }
    }
}

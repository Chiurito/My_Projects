using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Questa classe eredita la classe SingletonMonobehaviour. 
//La passo con il parametro di tipo <Player> e viene effettuato il codice all'interno di SingletonMonobehaviour.
//Lo scopo di SingletonMonobehaviour è controllare se ci sono più istanze dello stesso oggetto in esecuzione.
public class Player : SingletonMonobehaviour<Player>
{
    
}

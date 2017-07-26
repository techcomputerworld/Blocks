using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour {

    /*Para poder trabajar con las vidas, hay que poner esta variable publica en el objeto, Suelo*/
    public Vidas vidas;
    
    //esto para que no reste la vida voy a cambiarlo por lo de abajo
    /*
    private void OnTriggerEnter()
    {
        vidas.PerderVida();
        
    }*/
    
    
    private void OnCollisionEnter(Collision collision)
    {
        
        vidas.PerderVida();
    }
    
}

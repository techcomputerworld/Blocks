using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosSphere : MonoBehaviour {

    public AudioSource rebote;
    public AudioSource punto;
    public AudioSource error;

    private void Start()
    {
        error.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bloque"))
        {
            punto.Play();
        }
        else
        {
            rebote.Play();
        }
        //when collision on the floor that tag = "Suelo" Suelo in english is Floor, sound the sound error
        //cuando collision con el suelo que le he puesto la Tag = Etiqueta Suelo pues sonara el sonido.
        
        
        if (collision.gameObject.CompareTag("Suelo"))
        {
            error.enabled = true;
            error.Play();
        }
        
        
        
    }
}

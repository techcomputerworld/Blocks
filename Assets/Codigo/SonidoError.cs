using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoError : MonoBehaviour {

    public AudioSource sonidoFallo;

    public AudioClip sonidoError;

    public void Play()
    {
        sonidoFallo.clip = sonidoError;
        sonidoFallo.loop = false;
        sonidoFallo.Play();
    }

}

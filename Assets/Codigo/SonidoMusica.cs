using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMusica : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip musicaInicial;

    public void Play()
    {
        audioSource.clip = musicaInicial;
        audioSource.loop = true;
        audioSource.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour {
    public AudioSource audioSource;
    public AudioClip completado;
    public AudioClip gameOver;
    
	// estos 2 metodos son iguaoles solo que uno se le pasa el parametro gameOver o completado por tanto lo mejor es hacerlo en un metodo para el principio del DRY 
    // don't repeat your self 
    
    public void GameOver()
    {
        ReproducirSonido(gameOver);
    }
    public void NivelCompletado()
    {
        ReproducirSonido(completado);
    }
    
    
    void ReproducirSonido(AudioClip sonido)
    {
        audioSource.clip = sonido;
        audioSource.loop = false;
        audioSource.Play();
    }
}

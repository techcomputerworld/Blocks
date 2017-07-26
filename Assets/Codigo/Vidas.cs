using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

    public static int vidas = 3;

    public Text textoVidas;
    public Sphere sphere;
    public Barra barra;
    //hacvemos referencia al objeto porque lo que queremos es activar el objeto
    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;
    public SonidosFinPartida sonidosFinPartida;
    

	// Use this for initialization
	void Start () {
        //marcador de vidas
        ActualizarMarcadorVidas();

    }
	void ActualizarMarcadorVidas()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }
	
    public void PerderVida()
    {
        Vidas.vidas--;
        ActualizarMarcadorVidas();
        
        //realmente solo se activa cuando llegue a 0 el marcador de vidas y es cuando habremos perdido la partida
        if (vidas <= 0)
        {
            sonidosFinPartida.GameOver();
            //mostraremos GameOver
            gameOver.SetActive(true);
            sphere.DetenerMovimiento();
            sphere.gameObject.SetActive(false);
            //esto es para desactivar el componente 
            barra.enabled = false;
            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCarga();
        }
        else
        {
            
            barra.Reset();
            sphere.Reset();
        }
       
    }
}

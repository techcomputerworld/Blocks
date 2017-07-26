using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {
    public static int puntos = 0;
    public Text textoPuntos;

    public GameObject nivelCompletado;
    public GameObject juegoCompletado;

    public SiguienteNivel siguienteNivel;
    public Sphere sphere;
    public Barra barra;
    public Transform ContenedorBloques;
    public SonidosFinPartida sonidosFinPartida;
	// Use this for initialization

	void Start () {
        ActualizarMarcadorPuntos();

    }
    public void ganarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();
        if (ContenedorBloques.childCount<=0)
        {
            
            sphere.DetenerMovimiento();
            barra.enabled = false;
            //mostrar mensaje ¿cual mostramos? 
            if (siguienteNivel.EsUltimoNivel())
            {
                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }
            sonidosFinPartida.NivelCompletado();
            //hacemos referencia al objeto siguienteNivel
            siguienteNivel.ActivarCarga();
        }
    }
	void ActualizarMarcadorPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }
	
}

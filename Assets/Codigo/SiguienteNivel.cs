using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour {
    public string nivelACargar;
    public float retraso;
	
    //gracias a este truco podemos cargar los metodos sin que esten llamados desde otros script
    [ContextMenu("Activar Carga")]
    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);

    }
    void CargarNivel()
    {
        //Each Level, the player win a life 
        //cada nivel el jugador ganara una vida.
        //esta solucion no me convence mucho yo la desarrollare de otra manera seguramente por puntuacion o de otra manera 
        if (!EsUltimoNivel())
        {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(nivelACargar);
    }
    public bool EsUltimoNivel()
    {
        return nivelACargar == "Portada";
    }
}

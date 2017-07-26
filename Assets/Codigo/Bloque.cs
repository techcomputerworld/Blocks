using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

    public GameObject efectoParticulas;
    public Puntos puntos;
    // Is Trigger desactivado 
    // este metodo de dispara cuando la pelota colisiona con un 
	void OnCollisionEnter()
    {
        //transform.posicion seria la posicion del bloque que ha sido tocado por la pelota Sphere, Quaternion.Identity seria como decir la rotacion por defecto.
        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);
        // aparte de destruir cada bloque lo que haremos sera que ese bloque deje de ser hijo de bloques pq si no, no va a funcionar el metodo siguienteNivel.ChildCount() 
        transform.SetParent(null);
        puntos.ganarPunto();
    }
    // Is trigger activado
    /* 
    void OnTriggerEnter()
    {
        Debug.Log("TriggerEnter");
    }
    */
}

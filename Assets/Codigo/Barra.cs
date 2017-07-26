using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour {

    public float velocidad = 20;
    //la posicionInicial este valor lo ponemoss privado para que no podamos desde el inspector cambiarlo
    Vector3 posicionInicial;
    // Use this for initialization
	void Start () {
        posicionInicial = transform.position;
	}

    public void Reset()
    {
        //guardar la posicionInicial cada vez que se resetee.
        transform.position = posicionInicial;
    }
    
    // Update is called once per frame
 
	void Update () {
        //actualizaremos la posicion X de la barra
        // -1 para eje negativo, 0 si no se pulsa nada, 1 si se pulsa boton positivo
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        //calcular el eje x 
        //tecladoHorizontal -1 0 o 1 
        //velocidad sera 
        //dettatime es el tiempo por fotograma -6.15 8.75
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp( posX, -6.26f, 8.75f), transform.position.y, transform.position.z);
    }
}

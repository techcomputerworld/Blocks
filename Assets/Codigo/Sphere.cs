using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    public float velocidadInicial = 600f;
    public Rigidbody rig;
    bool enJuego = false;
    Vector3 posicionInicial;
    // esta propiedad para poder asignar el Transform de la barra en la pelota Sphere.
    public Transform barra;
    public SonidoError sonidoError;
    public SonidoMusica sonidoMusica; 
    private void Awake()
    {
        //referencia el objeto Sphere o tambien 
        //rig = GetComponent<Rigidbody>(); 
        /* podemos hacer la referencia por codigo de esta manera del objeto Transform 
         pero yo lo voy a hacer la asignacion desde Unity que me parece mas facil */   
        //barra = GetComponentInParent<Transform>();
    }
    // Use this for initialization
    void Start () {
        posicionInicial = transform.position;
        //empezar la musica 
        

    }
    public void Reset()
    {
        //guardar la posicionInicial cada vez que se resetee.
        transform.position = posicionInicial;
        transform.SetParent(barra);
        enJuego = false;
        DetenerMovimiento();
        
    }
    public void DetenerMovimiento()
    {
        rig.isKinematic = true;
        rig.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update () {
		if (!enJuego && Input.GetButtonDown("Fire1"))
        {
            enJuego = true;
            transform.SetParent(null);
            // esto para poner a false  esta propiedad y sera la fisica la que se encargue del movimiento.
            rig.isKinematic = false;
            rig.AddForce(new Vector3(velocidadInicial, velocidadInicial, 0));

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonSalir : MonoBehaviour {

    public bool salir;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir)
            {
                Debug.Log("salimos del juego");
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("Portada");
            }
            
        }
        
	}
}

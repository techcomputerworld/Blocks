using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarPartida : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            ResetLevel();
            SceneManager.LoadScene("Nivel01");
        }
	}
    void ResetLevel()
    {
        Vidas.vidas = 3;
        Puntos.puntos = 0;
    }
}

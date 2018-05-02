/**
 * Universidad del Valle de Guatemala
 * Oscar Juarez - 17315
 * Plataformas moviles y videojuegos
 * Fecha: 5/05/18
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string level;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {        
        /* Funcion encargada que, al colisionar con el objeto, cambie de escena */
        if (collision.tag.Equals("Player"))
        {
            SceneManager.LoadScene(level,LoadSceneMode.Single);
        }
    }
}

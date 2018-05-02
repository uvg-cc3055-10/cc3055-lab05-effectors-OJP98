/**
 * Universidad del Valle de Guatemala
 * Oscar Juarez - 17315
 * Plataformas moviles y videojuegos
 * Fecha: 5/05/18
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour
{
    /* Se declara la variable time */
    float time;
    public GameObject effector;

    // Use this for initialization
    void Start()
    {
        /* Se inicializa la variable time en 0 */
        time = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        //Se acumula el tiempo con el tiempo
        time += Time.deltaTime;

        //Si el timer llega a 10, se desactivan las particulas
        if (time >= 5)
        {
            effector.SetActive(false);
            
            if (time > 7)
            {
                time = 0;
            } 
            
        } else
        {
            effector.SetActive(true);
        } 

        Debug.Log("Time:" + time);

    }
}
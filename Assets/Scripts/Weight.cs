/**
 * Universidad del Valle de Guatemala
 * Oscar Juarez - 17315
 * Plataformas moviles y videojuegos
 * Fecha: 5/05/18
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {

    /* Se declaran las variables / objetos a utilizar */
    LineRenderer line;
    DistanceJoint2D distanceJoint;

	// Use this for initialization
	void Start () {

        /* Se obtienen los componentes de las variables */
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();    
    }
	
	// Update is called once per frame
	void Update () {

        /* Crea la linea entre el objeto y a lo que esta unido */
        line.SetPosition(0, transform.position);
        line.SetPosition(1, distanceJoint.connectedBody.transform.position);

    }
}

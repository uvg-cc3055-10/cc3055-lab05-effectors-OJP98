/**
 * Universidad del Valle de Guatemala
 * Oscar Juarez - 17315
 * Plataformas moviles y videojuegos
 * Fecha: 5/05/18
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {

    /* Se declaran las variables a utilizar */
    Rigidbody2D rb2d;
    SpriteRenderer sr;
    Animator anim;
    private float speed = 5f;
    private float jumpForce = 250f;
    private bool facingRight = true;
    public GameObject feet;
    public LayerMask layerMask;


	void Start () {

        /* Se obtienen los componentes de dichas variables */
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        //feet = GetComponent<GameObject>();
    }
	

	void Update () {

        /* Variable moev encargada de mover al personaje en
         el eje horizontal */
        float move = Input.GetAxis("Horizontal");

        /* Si el personaje no se mueve, se declara para que este
         viendo hacia al frente */
        if (move != 0) {
            rb2d.transform.Translate(new Vector3(1, 0, 0) * move * speed * Time.deltaTime);
            facingRight = move > 0;
        }

        /* Se empieza con la animacion */
        anim.SetFloat("Speed", Mathf.Abs(move));

        sr.flipX = !facingRight;

        /* Si se apreta la barra espaciadora, el personaje realiza 
         una serie de funciones */
        if (Input.GetButtonDown("Jump"))
        {
            //rb2d.AddForce(Vector2.up * jumpForce);
            RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layerMask);
            if (raycast.collider != null) rb2d.AddForce(Vector2.up * jumpForce);            
        }
    }
}

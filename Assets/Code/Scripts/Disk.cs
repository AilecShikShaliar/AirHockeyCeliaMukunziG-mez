using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    //Velocidad del disco
    public float diskSpeed = 25f;

    //Esto es una referencia al RigidBody del disco que nos permite cambiar su velocidad
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //El disco empieza con una velocidad que lo impulsa a la derecha
        rb.velocity = Vector2.right * diskSpeed; //Equivale a new Vector2(1, 0)
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* 
     * El objeto collision del paréntesis contiene la información del choque
     * En particular, nos interesa saber cuando choca contra una pala.
     * -collision.gameObject: tiene información del objeto contra el cuál ha colisionado (la pala)
     * -collision.transform.position: tiene información de la posición (pala)
     * -collision.collider: tiene información del collider (pala)
     */

    /* Es un método de Unity que detecta colisión entre dos GO.
     * Al chocar el disco contra el objeto que choca le pasa su Colisión por parámetro */
    private void OnCollisionEnter2D(Collision2D collision) //El parámetro collision es el objeto que ha chocado contra el disco
    {
        
    }
}

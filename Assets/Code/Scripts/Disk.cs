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
     * El objeto collision del par�ntesis contiene la informaci�n del choque
     * En particular, nos interesa saber cuando choca contra una pala.
     * -collision.gameObject: tiene informaci�n del objeto contra el cu�l ha colisionado (la pala)
     * -collision.transform.position: tiene informaci�n de la posici�n (pala)
     * -collision.collider: tiene informaci�n del collider (pala)
     */

    /* Es un m�todo de Unity que detecta colisi�n entre dos GO.
     * Al chocar el disco contra el objeto que choca le pasa su Colisi�n por par�metro */
    private void OnCollisionEnter2D(Collision2D collision) //El par�metro collision es el objeto que ha chocado contra el disco
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Referencia para guardar la direcci�n del disco
    Vector2 direction;
    //Referencia al disco
    public GameObject disk;
    //Referencia para las palas
    public GameObject playerLeft, playerRight;

    //M�todo para hacer lo que ocurre al marcar un punto
    public void GoalScored()
    {
        //Ponemos el disco al marcar un gol en la posici�n de origen
        disk.transform.position = Vector2.zero; //Vector2.zero <-> new Vector2(0,0)
        //Ponemos a los jugadores en sus posiciones de origen
        playerLeft.transform.position = new Vector2(-6.75f, 0f);
        playerRight.transform.position = new Vector2(6.75f, 0f);

        //Aqu� guardamos la velocidad en X que llevaba el disco e invertimos su signo
        direction = new Vector2(-disk.GetComponent<Rigidbody2D>().velocity.x, 0f);

        //Paramos el disco
        disk.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    //M�todo para hacer que el disco se lance
    void LaunchDisk()
    {
        //Aplicamos esa nueva direcci�n en el disco
        disk.GetComponent<Rigidbody2D>().velocity = direction;
    }
}

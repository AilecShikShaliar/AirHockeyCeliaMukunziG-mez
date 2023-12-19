using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Librer�a que sirve para cambiar entre escenas

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //M�todo que usamos desde el bot�n de Play para ir a la escena de juego
    public void ChangeScene()
    {
        //Carga la escena con ese nombre
        SceneManager.LoadScene("Game");
    }
}

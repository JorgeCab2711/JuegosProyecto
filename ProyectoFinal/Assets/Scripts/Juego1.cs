using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego1 : MonoBehaviour
{
    private bool enter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        // Si el player ha entrado en contacto con el collider de la puerta
        if (enter)
        {
            // Se muestra el mensaje de interaccion
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'F' to open the door");
        }
    }
}

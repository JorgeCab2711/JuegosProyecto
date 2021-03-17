using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetreroPrincipal : MonoBehaviour
{
   
    public GameObject His;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que ha entrado en colision es el player
        if (other.gameObject.tag == "Player")
        {
            // Colocamos la variable enter a true
            Historia();
        }
    }

    // Trigger que detecta cuando un objeto ha salido de colision con el objeto que tiene asignado este script
    private void OnTriggerExit(Collider other)
    {
        // Si el objeto que ha salido de colision es el player
        if (other.gameObject.tag == "Player")
        {
            // Colocamos la variable enter a false
            Apagado();
        }
    }
    private void Historia()
    {
        if (His)
        {

            His.SetActive(true);

        }
    }
    private void Apagado()
    {
        if (His)
        {
            His.SetActive(false);
        }
    }
}

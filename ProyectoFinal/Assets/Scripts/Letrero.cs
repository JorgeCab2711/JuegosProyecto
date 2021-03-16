using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letrero : MonoBehaviour
{
    public GameObject objeto;
   

    // Start is called before the first frame update
    void Start()
    {
        objeto.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Colocamos la variable enter a true
            objeto.SetActive(true);
        }
    }
}

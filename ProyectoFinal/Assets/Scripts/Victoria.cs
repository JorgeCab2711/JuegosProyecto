using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (score > 1)
        {
            Victory();
        }
        print(score);
    }
    private void OnTriggerEnter(Collider other)
    {
        // Si el objeto que ha entrado en colision es el player
        if (other.gameObject.tag == "Objeto")
        {
            // Colocamos la variable enter a true
            score++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Si el objeto que ha salido de colision es el player
        if (other.gameObject.tag == "Objeto")
        {
            // Colocamos la variable enter a false
            score--;
        }
    }
    private void Victory()
    {
        SceneManager.LoadScene(2);
    }
}

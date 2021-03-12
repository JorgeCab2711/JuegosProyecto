using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{


    public AudioClip Linternas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("mouse 1"))
        {
            GetComponent<AudioSource>().PlayOneShot(Linternas);
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
            
            



    }
}
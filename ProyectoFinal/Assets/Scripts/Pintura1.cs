using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintura1 : MonoBehaviour
{
    public AudioClip pintura1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            GetComponent<AudioSource>().PlayOneShot(pintura1);

        }
    }
}

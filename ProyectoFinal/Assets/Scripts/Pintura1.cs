using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pintura1 : MonoBehaviour
{
    public AudioClip pintura1;
    
    private bool hasPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player") && !hasPlayed)
        {
            hasPlayed = true;
            GetComponent<AudioSource>().PlayOneShot(pintura1);
            

        }
    }
}

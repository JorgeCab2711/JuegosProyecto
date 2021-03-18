using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWendigox : MonoBehaviour
{
    public AudioSource playSound;

    private bool hasPassed = false;

    private void OnTriggerEnter(Collider other) {
        if(!hasPassed)
            hasPassed = true;
            playSound.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detroyplayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }
    }
}

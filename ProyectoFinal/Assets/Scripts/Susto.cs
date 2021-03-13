using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Susto : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed;
    public AudioClip susto;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 20.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
     
            m_Rigidbody.velocity = -transform.right * m_Speed;
            GetComponent<AudioSource>().PlayOneShot(susto);

        }
    }
}
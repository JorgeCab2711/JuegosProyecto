using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public float speed;
    public float Angle;
    public Vector3 direction;

    public bool puertaAbrir;
    public bool abrir;

    // Start is called before the first frame update
    void Start()
    {
        Angle = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Round(transform.eulerAngles.y) != Angle)
        {
            transform.Rotate(direction * speed);
        }
        if (Input.GetKeyDown(KeyCode.E) && puertaAbrir == true && abrir == false)
        {
            Angle = 80;
            direction = Vector3.up;
            abrir = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && puertaAbrir == true && abrir == true)
        {
            Angle = 0;
            direction = Vector3.down;
            abrir = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            puertaAbrir = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            puertaAbrir = false;
        }
    }
}

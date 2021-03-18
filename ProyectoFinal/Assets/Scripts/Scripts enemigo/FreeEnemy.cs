using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeEnemy : MonoBehaviour
{
    public GameObject puerta;
    public Transform doorPosition;

    public GameObject trigger;

    public GameObject cartel ;

    private Vector3 enemyScale ;

    private bool hasPassed = false;

    private bool hasDestroyed = false; 

    
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
        if (!hasPassed)
            hasPassed = true;
            Instantiate(puerta, doorPosition.position, doorPosition.rotation);
            puerta.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
            if (!hasDestroyed)
                Destroy(cartel);
                Destroy(puerta);
    }

    
    
}

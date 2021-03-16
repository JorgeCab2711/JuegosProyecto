using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPosition;

    public GameObject trigger;

    public GameObject cartel ;

    private Vector3 enemyScale ;
    
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
        Instantiate(enemy, enemyPosition.position, enemyPosition.rotation);
        enemy.transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
        Destroy(trigger);
        Destroy(cartel);
    }
    
}

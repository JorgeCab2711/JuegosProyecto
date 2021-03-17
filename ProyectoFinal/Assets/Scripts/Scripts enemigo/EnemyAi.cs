using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAi : MonoBehaviour
{


    public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //Patrolling
    public Vector3  walkPoint;
    bool walkPointset;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAtacks;
    bool alreadyAttacked;

    //States
    public float sightRange, atackRange;
    public bool playerInSightRange , playerInAttackRange;
    
    private void Awake() {
        player = GameObject.Find("FPSController").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        //Checkear si el jugador está a la vista del enemigo en todo momento
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, atackRange, whatIsPlayer);

        if(!playerInSightRange && !playerInAttackRange) Patrolling();
        if(playerInSightRange && !playerInAttackRange) ChasePlayer();
        if(playerInSightRange && playerInAttackRange) AttackPlayer();



    }

    private void Patrolling(){
        if(!walkPointset) SearchWalkPoint();
    }

    private void SearchWalkPoint(){
        //Calcular un punto aleatorio en el rango
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround)){
            //walkPointset;
        }


    }
    private void ChasePlayer(){

    }
    private void AttackPlayer(){

    }
    

    
}

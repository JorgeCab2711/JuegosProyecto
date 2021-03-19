using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{   
    
    public GameObject waypointsObject;
    NavMeshAgent nav ;

    List<Vector3> waypoints;

    int currentWP = 0;

    private bool notInRange = true;

    public bool getNotInRange(){
        return this.notInRange;
    }

    public void setNotInRange(bool Input_){
        notInRange = Input_;
    }

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        waypoints = new List<Vector3>();

        if (waypointsObject && notInRange){
            foreach(Transform child in waypointsObject.transform){
                waypoints.Add(child.position);
            }
        }

        if(waypoints.Count > 0 && nav && notInRange){
            nav.SetDestination(waypoints[currentWP]);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nav && notInRange){
            if (nav.remainingDistance < 0.5f){
                currentWP++;
                currentWP = currentWP % waypoints.Count;

                nav.SetDestination(waypoints[currentWP]);
            }
        }
    }
    
}

 using UnityEngine;
 using UnityEngine.AI;
 using System.Collections;
 
 public class DetectPlayer : MonoBehaviour {
 
     NavMeshAgent agent;
     public Transform target;
     public GameObject Player;
     public bool follow = false;
 
     // Use this for initialization
     void Start () {
         agent = GetComponent<NavMeshAgent> ();
     }
     
     // Update is called once per frame
     void Update () {
         if (follow == true) {
             agent.SetDestination (target.position);
         }
     }
 
     void OnTriggerEnter (Collider col) {
             //checking if player collides with trigger
         if (col.GetComponent<Collider>().tag == Player.tag) {
             follow = true;
         }
     }
 }

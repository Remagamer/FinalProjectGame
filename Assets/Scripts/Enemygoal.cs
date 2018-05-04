using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemygoal : MonoBehaviour {

    private Transform goal;
    private UnityEngine.AI.NavMeshAgent agent;
       
    void Start () {
          agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
          agent.destination = GameObject.Find("Player").GetComponent<Transform>().position; 
	}

	void Update () {
		agent.destination = GameObject.Find("Player").GetComponent<Transform>().position;
	}
}
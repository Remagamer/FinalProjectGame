using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	//lay out our stuff
	public CharacterController Control1;
	public ScriptableObject Stats;
	//lay out the vector3 to move with
	private Vector3 Movement;


	// Use this for initialization
	void Start () {
		//get it in place.
		Control1 = GetComponent<CharacterController>();
		Stats = GetComponent<ScriptableObject>();
	}
	
	// Update is called once per frame
	void Update () {
		//clean the Movement.
		Movement.x = 0;
		//check gravity.
		if (Control1.isGrounded) {
			Movement.y = 0;
		}
		else
		{
			Movement.y -= 1;
		}
		//apply the stats.
		Movement.x *= Stats.Speed; 
		Movement.y *= Stats.Jump;
		//apply the Movement.
		Control1.Move(Movement);
	}
}

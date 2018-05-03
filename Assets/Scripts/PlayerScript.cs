using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	//lay out our stuff
	private CharacterController Control1;
	public ScriptableObject Stats;
	//lay out the vector3 to move with
	private Vector3 Movement;
	//I spent two hours trying to put this into a scriptableobject but nothing can get into it no matter what I do and that's beans man
	public float Health = 1;
	public int Speed = 1;
	public int Jump = 5;


	// Use this for initialization
	void Start () {
		//get it in place.
		Control1 = GetComponent<CharacterController>();
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
			Movement.y -= .01F;
		}
		//apply the stats.
		Movement.x *= Speed; 
		Movement.y *= Jump;
		//apply the Movement.
		Control1.Move(Movement);
	}
}

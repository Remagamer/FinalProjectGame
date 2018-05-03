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
	public float Speed = 1;
	public float Gravity = 3;
	public float Jump = 2;


	// Use this for initialization
	void Start () {
		//get it in place.
		Control1 = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//clean the Movement.
		Movement.x = 0;
		//get movement.
		Movement.x = Input.GetAxis("Horizontal");
		//check gravity.
		if (Control1.isGrounded) {
			Movement.y = 0;
			//get jump.
			if (Input.GetButton("Jump"))
			{
				Movement.y = Jump;
			}
		}
		else
		{
			Movement.y -= Gravity;
		}
		//apply the stats.
		Movement.x *= Speed; 
		//apply the Movement.
		Control1.Move(Movement);
	}
}

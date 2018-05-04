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
	public List<float> Statlist;
	//1 is speed,
	//2 is jump,
	//3 is gravity,
	//4 is health,
	//5 is score.

	//the list that holds 3 keys.
	public List<string> Keylist;

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
				Movement.y = Statlist[2];
			}
		}
		else
		{
			Movement.y -= Statlist[3];
		}
		//apply the stats.
		Movement.x *= Statlist[1]; 
		//apply the Movement.
		Control1.Move(Movement);
	}
} 

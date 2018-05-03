using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	//lay out our stuff
	public CharacterController Control1;
	public ScriptableObject Stats;

	// Use this for initialization
	void Start () {
		//get it in place.
		Control1 = GetComponent<CharacterController>();
		Stats = GetComponent<ScriptableObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Control1.isGrounded) {
			S
		}
	}
}

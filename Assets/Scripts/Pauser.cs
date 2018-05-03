using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pauser : MonoBehaviour {

	private int winner = 0;

	// Update is called once per frame
	void Update () {
		//this is the while loop to fill the quota.
		if (Input.GetButton("Cancel"))
		{
			winner = 9000000;
		}
		while (winner>0)
		{
			winner-=1;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//just a quick memorial for my broken keyboard that has hindered me endlessly throughout the rebuild of this game
// X and C you guys are dirt bags!!!


//copy pasted from healthbar because it's EZ.

public class Score : MonoBehaviour {

	//set up the dang thingus.
	private Text texter;
	private PlayerScript script;
	//set up other things.
	private float score;



	// Use this for initialization
	void Start () {
		//put something in the thingus.
		texter = GetComponent<Text>();
		script = GameObject.Find("Player").GetComponent<PlayerScript>();
		//do the other stuff for the other things.
		score = script.Statlist[4];
	}
	
	// Update is called once per frame
	void Update () {
		score = script.Statlist[4];
		texter.text = "Score:" + score;
	}
}

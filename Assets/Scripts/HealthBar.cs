using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//just a quick memorial for my broken keyboard that has hindered me endlessly throughout the rebuild of this game
// X and C you guys are dirt bags!!!

public class HealthBar : MonoBehaviour {

	//set up the dang thingus.
	private Image imager;
	private PlayerScript script;
	//set up other things.
	private float health;



	// Use this for initialization
	void Start () {
		//put something in the thingus.
		imager = GetComponent<Image>();
		script = GameObject.Find("Player").GetComponent<PlayerScript>();
		//do the other stuff for the other things.
		health = script.Statlist[4];
	}
	
	// Update is called once per frame
	void Update () {
		health = script.Statlist[4];
		imager.fillAmount = health;
	}
}

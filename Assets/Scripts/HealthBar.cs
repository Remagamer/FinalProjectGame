using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	//set up the dang thingus.
	private Image imager;
	private PlayerScript script;
	//set up other things.
	protected float health;



	// Use this for initialization
	void Start () {
		//put something in the thingus.
		imager = GetComponent<Image>();
		script = GameObject.Find("Player").GetComponent<PlayerScript>();
		//do the other stuff for the other things.
		health = script.Health;
	}
	
	// Update is called once per frame
	void Update () {
		health = script.Health;
		imager.fillAmount = health;
	}
}

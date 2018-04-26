using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	//set up the dang thingus.
	protected Image imager;
	//set up other things.
	protected float health;



	// Use this for initialization
	void Start () {
		//put something in the thingus.
		imager = GetComponent<Image>();
		//do the other stuff for the other things.
		health = GameObject.Find("Guy").GetComponent<PlayerMove2>().healthAmount;
	}
	
	// Update is called once per frame
	void Update () {
		imager.fillAmount = health / 100;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour {
	
	public int frames = 0;
	public int seconds = 0;
	public int minutes = 0;
	protected Text texter;

	//Start
	void Start () {
		texter = GetComponent<Text>();
	}
	// Update is called once per frame
	void Update () {
		frames+=1;
		if (frames >= 60) {
			frames=0;
			seconds+=1;
		}
		if (seconds >= 60) {
			seconds=0;
			minutes+=1;
		}
		texter.text = "Time:" + minutes + ":" + seconds;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

	//on trigger enter stuff.
	void OnTriggerEnter(Collider other)
	{
		//other.healthAmount -=1;
		Destroy(this);
	}
}

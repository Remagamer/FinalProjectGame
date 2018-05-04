using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    private PlayerScript scripto;

    //this would be in a scriptable object but they're impenetrable vaults of untouchability. I don't understand how to get things in or out of them.
	public string color;

	void Start() {
		
	}
    void OnTriggerEnter(Collider other) {

        scripto = other.GetComponent<PlayerScript>();

		scripto.Keylist.Add(color);

        Destroy(gameObject);
    }

}
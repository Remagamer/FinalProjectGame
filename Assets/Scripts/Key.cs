using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public PlayerScript scripto;

	public Key key;

	void Start() {
		
	}
    void OnTriggerEnter(Collider other) {

        scripto = other.GetComponent<PlayerScript>();

		//scripto.Keylist.Add(key.color);

        Destroy(gameObject);
    }

}
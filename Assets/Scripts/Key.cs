using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    private PlayerScript scripto;

	public Key key;

	void Start() {
		
	}
    void OnTriggerEnter(Collider other) {

        scripto = other.GetComponent<PlayerScript>();

		//scripto.Keylist.Add(key.GetColor());

        Destroy(gameObject);
    }

}
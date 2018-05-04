using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public PlayerScript script;

	private KeyBase key;

    void OnTriggerEnter(Collider other) {

        script = other.GetComponent<PlayerScript>();

		script.Keylist.Add(key.GetColor());

        Destroy(gameObject);
    }

}
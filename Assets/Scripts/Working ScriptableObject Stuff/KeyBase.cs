using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
abstract class KeyBase : Key {

	//the color of the key.
	public string color;

	public string GetColor() {
		return color;
	}
}

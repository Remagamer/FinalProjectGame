using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        //Debug.Log("Collision detected!");
        print("Collision detected!");
    }
}
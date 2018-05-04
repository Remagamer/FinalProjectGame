﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public PlayerScript script;
    //stat changes.
    public List<float> Statlist;

    void OnTriggerEnter(Collider other) {
        //Debug.Log("Collision detected!");

        //change stats.
        script = other.GetComponent<PlayerScript>();
        //stat changes.
        for (int value = 0 ; value < 4; value++)
        {
            //do the thing.
            script.Statlist[value] += Statlist[value];
        }
        //script.Health += HP;
	    //script.Speed += SPD;
	    //script.Gravity += GRAV;
	    //script.Jump += JMP;
        //kill the object.
        Destroy(gameObject);
    }

}
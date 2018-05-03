using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public PlayerScript script;
    //stat changes.
    public float HP = 0;
    public float JMP = 0;
    public float GRAV = 0;
    public float SPD = 0;


    void OnTriggerEnter(Collider other) {
        //Debug.Log("Collision detected!");

        //change stats.
        script = other.GetComponent<PlayerScript>();
        script.Health += HP;
	    script.Speed += SPD;
	    script.Gravity += GRAV;
	    script.Jump += JMP;
        //kill the object.xxxxxxxxxxxxxxxxx
        Destroy(gameObject);
    }

}
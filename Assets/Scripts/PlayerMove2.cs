using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour {

	public float healthAmount = 100.0F;

	protected Vector3 moveDirection;
	protected Rigidbody2D box;
	
	void Start()
	{
		box = GetComponent<Rigidbody2D>();
	}
	void Update()
	{	
		//reset transform
		moveDirection *= 0;
		//get inputs
		if (Input.GetAxisRaw("Horizontal") == 1)
		{
			moveDirection.x = 15;
		}
		if (Input.GetAxisRaw("Horizontal") == -1)
		{
			moveDirection.x = -15;
		}
		//get jump input
		if (Input.GetButton("Jump") && Physics2D.Raycast(transform.position, Vector2.down, 2.2F))
		{
			moveDirection.y = 200;
		}
		//apply the transform
		box.AddForce(moveDirection);

		
	}	

}
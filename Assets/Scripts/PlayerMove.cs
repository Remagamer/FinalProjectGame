using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float Health = 100.0F;

	protected Vector3 moveDirection;
	protected Transform transformer;
	
	void Start()
	{
		transformer = GetComponent<Transform>();
	}
	void Update()
	{	
		//reset transform
		moveDirection.x = 0;
		//apply gravity
		if (Physics2D.Raycast(transformer.position, Vector2.down, .8F))
		{
			moveDirection.y = 0;
		}
		else
		{
			moveDirection.y-= .05F;
		}
		//get inputs
		if (Input.GetAxis("Horizontal") > 0)
		{
			if (Physics2D.Raycast(transformer.position, Vector2.right, .5F))
      	    {
				moveDirection.x = 0;
    	    }
			else
			{
				moveDirection.x = .5F;
			}
		}
		if (Input.GetAxis("Horizontal") < 0)
		{
			if (Physics2D.Raycast(transformer.position, Vector2.left, .5F))
      	    {
				moveDirection.x = 0;
    	    }
			else
			{
				moveDirection.x = -.5F;
			}
		}
		//get jump input
		if (Input.GetButton("Jump") && Physics2D.Raycast(transformer.position, Vector2.down, 1))
		{
			moveDirection.y = .5F;
		}
		//move the transform
		transformer.position+=moveDirection;
	}	
}
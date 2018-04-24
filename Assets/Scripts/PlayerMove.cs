using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float Health = 100.0F;

	protected Vector3 moveDirection;
	protected Transform transformer;
	protected SpriteRenderer render;
	
	void Start()
	{
		transformer = GetComponent<Transform>();
	}
	void Update()
	{	
		//debug stuff

		Debug.Log(Input.GetAxisRaw("Horizontal"));

		//end debug stuff

		//reset transform
		moveDirection.x = 0;
		//apply gravity
		if (Physics2D.Raycast(transformer.position, Vector2.down, 2.2F))
		{
			moveDirection.y = 0;
		}
		else
		{
			moveDirection.y-= .05F;
		}
		//get inputsF
		if (Input.GetAxisRaw("Horizontal") == 1)
		{
			if (Physics2D.Raycast(transformer.position, Vector2.right, 2.2F))
      	    {
				moveDirection.x = 0;
    	    }
			else
			{
				moveDirection.x = .5F;
				render.flipX = false;
			}
		}
		if (Input.GetAxisRaw("Horizontal") == -1)
		{
			if (Physics2D.Raycast(transformer.position, Vector2.left, 2.2F))
      	    {
				moveDirection.x = 0;
    	    }
			else
			{
				moveDirection.x = -.5F;
				render.flipX = true;

			}
		}
		//get jump input
		if (Input.GetButton("Jump") && Physics2D.Raycast(transformer.position, Vector2.down, 2.3F	))
		{
			moveDirection.y = 1;
		}
		//move the transform
		transformer.position+=moveDirection;
	}	
}
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
		render = GetComponent<SpriteRenderer>();
	}
	void Update()
	{	
		//reset transform
		moveDirection.x = 0;
		//apply gravity to the transform
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
		if (Input.GetButton("Jump") && Physics2D.Raycast(transformer.position, Vector2.down, 2.3F))
		{
			moveDirection.y = 1;
		}
		//check for head collisions.
		if (Physics2D.Raycast(transformer.position, Vector2.up, 2.2F))
		{
			moveDirection.y = -.25F;
		}
		//apply the transform
		transformer.position+=moveDirection;
	}	
}
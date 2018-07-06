using System.Collections;
using System.Collections.Generic;
using QGame;
using UnityEngine;

public class PlayerController : QScript
{
	public float Speed;

	private void CheckMovement()
	{
		var delta = Time.deltaTime;
		if (Input.GetAxis("Horizontal") < 0)
		{
			transform.position = new Vector3(transform.position.x - Speed * delta, transform.position.y, 0);
		}
	    else if (Input.GetAxis("Horizontal") > 0)
	    {
	        transform.position = new Vector3(transform.position.x + Speed * delta, transform.position.y, 0);
	    }

        if (Input.GetAxis("Vertical") > 0)
		{
		    transform.position = new Vector3(transform.position.x, transform.position.y + Speed * delta, 0);
		}
        else if (Input.GetAxis("Vertical") < 0)
		{
		    transform.position = new Vector3(transform.position.x, transform.position.y - Speed * delta, 0);
		}
    }


	// Use this for initialization
	void Start ()
	{
	    OnEveryUpdate += CheckMovement;
	}
}

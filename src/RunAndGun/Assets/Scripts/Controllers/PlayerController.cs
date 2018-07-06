using System.Collections;
using System.Collections.Generic;
using QGame;
using UnityEngine;

public class PlayerController : QScript
{
	public float Speed;

	// Use this for initialization
	void Start ()
	{
	    OnEveryUpdate += CheckMovement;
	    OnEveryUpdate += LookAtMouse;
	}

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

    private void LookAtMouse()
    {
        var diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        var rotation = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation - 90);
    }
}

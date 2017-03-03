using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experimental1 : MonoBehaviour {

	private float xPoint, yPoint, angle, speed, direction;
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		angle = 0;
		direction = 1; //1 or -1
		speed = 0.5f; //speed = 1 indicates that one full circular round gets completed in 1 second
	}

	void UpdatePosition()
	{
		xPoint = angle * angle + angle;
		yPoint = 2 * angle + 1;
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		transform.position = newPosition;
		angle = angle + 2 * Mathf.PI * Time.deltaTime * speed * direction;
		if(angle > 2 * Mathf.PI)
		{
			direction = -1;
		}
		if(angle < -2 * Mathf.PI)
		{
			direction = 1;
		}
	}
		
	// Update is called once per frame
	void Update ()
	{
		UpdatePosition();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experimental2 : MonoBehaviour {

	private float xPoint, yPoint, zPoint, angle, speed, direction, minorRadius, majorRadius, u;
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		angle = 0;
		majorRadius = 2f;
		minorRadius = 0.5f;
		direction = 1; //1 or -1
		speed = 0.5f; //speed = 1 indicates that one full circular round gets completed in 1 second
	}

	void UpdatePosition()
	{
		xPoint = Mathf.Cos(angle) * (majorRadius + minorRadius * Mathf.Cos(u));
		yPoint = Mathf.Sin(angle) * (majorRadius + minorRadius * Mathf.Cos(u));
		zPoint = minorRadius * Mathf.Sin(u);
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		newPosition.y = zPoint;
		transform.position = newPosition;
		angle = angle + 2 * Mathf.PI * Time.deltaTime * speed * direction;
		u = angle;
		/*
		if(angle > 2 * Mathf.PI)
		{
			direction = -1;
		}
		if(angle < 0)
		{
			direction = 1;
		}*/
	}
		
	// Update is called once per frame
	void Update ()
	{
		UpdatePosition();
	}
}

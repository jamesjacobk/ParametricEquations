using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour {

	private float radius, xPoint, yPoint, angle, speed, direction, a, b;
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		a = 0.1f;
		b = 0.1f;
		angle = 0;
		radius = 1f;
		direction = 1; //1 or -1
		speed = 0.5f; //speed = 1 indicates that one full circular round gets completed in 1 second
	}

	void UpdatePosition()
	{
		xPoint = radius * Mathf.Cos(angle);
		yPoint = radius * Mathf.Sin(angle);
		radius = a * Mathf.Exp(b * angle);
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		transform.position = newPosition;
		angle = angle + 2 * Mathf.PI * Time.deltaTime * speed * direction;
		if(angle > Mathf.PI * 20)
		{
			direction = -1;
		}
		if(angle < 0)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : MonoBehaviour {

	//parametric equation of an ellipse
	//x = cx + 2 * r * cos(a)
	//y = cy + r * sin(a)

	private float xPoint, yPoint, xCenter, yCenter, radius, angle, speed;
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		xCenter = 0;
		yCenter = 0;
		radius = 5f;
		angle = 0;
		speed = 0.5f; //speed = 1 indicates that one full circular round gets completed in 1 second
	}

	void UpdatePosition()
	{
		xPoint = xCenter + 2 * radius * Mathf.Cos(angle);
		yPoint = yCenter + radius * Mathf.Sin(angle);
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		transform.position = newPosition;
		angle = angle + 2 * Mathf.PI * Time.deltaTime * speed;
		if(angle > 2 * Mathf.PI)
		{
			angle = 0;
		}
	}
		
	// Update is called once per frame
	void Update ()
	{
		UpdatePosition();
	}
}

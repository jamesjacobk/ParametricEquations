using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	//Parametric equation of line
	//x = (1 - t) * x0 + t * x1
	//y = (1 - t) * y0 + t * y1

	private float xPoint, yPoint, xStart, xEnd, yStart, yEnd, time, direction; 
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		xStart = 0;
		yStart = 0;
		xEnd = 10;
		yEnd = 10;
		time = 0;
		direction = 1; //+1 or -1
	}

	void UpdatePosition()
	{
		xPoint = (1 - time) * xStart + time * xEnd;
		yPoint = (1 - time) * yStart + time * yEnd;
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		transform.position = newPosition;
		time += 0.01f * direction;
		if(time > 1)
		{
			direction = -1;
		}
		if(time < 0)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parabola : MonoBehaviour {

	private float xPoint, yPoint, time, direction; 
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		time = 0;
		direction = 1; //+1 or -1
	}

	void UpdatePosition()
	{
		xPoint = time;
		yPoint = time * time;
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		transform.position = newPosition;
		time += 0.01f * direction;
		if(time > 2)
		{
			direction = -1;
		}
		if(time < -2)
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

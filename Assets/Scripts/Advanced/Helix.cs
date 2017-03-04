using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helix : MonoBehaviour {

	private float xPoint, yPoint, angle, speed, direction, verticalSeparation;
	private Vector3 newPosition;

	// Use this for initialization
	void Start ()
	{
		angle = 0;
		direction = 1; //1 or -1
		verticalSeparation = 0.01f;
		speed = 0.5f; //speed = 1 indicates that one full circular round gets completed in 1 second
	}

	void UpdatePosition()
	{
		xPoint = Mathf.Sin(angle);
		yPoint = Mathf.Cos(angle);
		newPosition = transform.position;
		newPosition.x = xPoint;
		newPosition.z = yPoint;
		newPosition.y += verticalSeparation; 
		transform.position = newPosition;
		angle = angle + 2 * Mathf.PI * Time.deltaTime * speed * direction;

	}
		
	// Update is called once per frame
	void Update ()
	{
		UpdatePosition();
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{

	public int speed;

	private bool doRotate = false;

	void Update ()
	{
		if (Input.GetMouseButtonUp (0)) {
			doRotate = !doRotate;
		}
		if (doRotate) {
			//transform.Rotate(Vector3.up * 10 * Time.deltaTime, Space.World);
//			transform.RotateAround (Vector3.zero, Vector3.up, 20 * Time.deltaTime);
			transform.RotateAround (transform.position, transform.up, speed * Time.deltaTime);
		}
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMover : MonoBehaviour
{
	private GameObject camera;
	private Transform target;

	void Start ()
	{
		Destroy (gameObject, 2f);
		camera = GameObject.FindWithTag ("MainCamera");
		target = camera.transform;
	}

	void Update ()
	{
		transform.position = Vector3.MoveTowards (transform.position, target.position, Time.deltaTime * 100);
	}
}

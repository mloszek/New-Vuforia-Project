using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterationController : MonoBehaviour
{

	public int iterations;
	public int angle;
	public float scale;
	public int angleIndex;

	private float cosinValueOfAngle;
	private float sinValueOfAngle;
	private GameObject child1;
	private GameObject child2;

	void Start ()
	{
		angleIndex++;
		GenerateChildren ();
	}

	void GenerateChildren ()
	{

		iterations--;
		if (iterations > 0) {

			child1 = Instantiate (gameObject);
				child2 = Instantiate (gameObject);

			child1.transform.localScale = gameObject.transform.lossyScale * scale;
			child2.transform.localScale = gameObject.transform.lossyScale * scale;

			child1.transform.position = new Vector3 (
				gameObject.transform.position.x + Mathf.Cos ((angle * angleIndex * Mathf.PI) / 180) * ((gameObject.transform.lossyScale.x + child1.transform.lossyScale.x) / 2), 
				gameObject.transform.position.y + Mathf.Sin ((angle * angleIndex * Mathf.PI) / 180) * ((gameObject.transform.lossyScale.x + child1.transform.lossyScale.x) / 2), 
				0);
			child2.transform.position = new Vector3 (
				gameObject.transform.position.x - Mathf.Cos ((angle * -angleIndex * Mathf.PI) / 180) * ((gameObject.transform.lossyScale.x + child1.transform.lossyScale.x) / 2), 
				gameObject.transform.position.y + Mathf.Sin ((angle * angleIndex * Mathf.PI) / 180) * ((gameObject.transform.lossyScale.x + child1.transform.lossyScale.x) / 2), 
				0);
			
			child1.transform.parent = gameObject.transform;
			child2.transform.parent = gameObject.transform;

//			child1.transform.rotation = Quaternion.Euler (0, 0, -angle);
//			child2.transform.rotation = Quaternion.Euler (0, 0, angle);

		}
	}
}

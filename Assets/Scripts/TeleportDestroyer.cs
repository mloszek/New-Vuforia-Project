using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDestroyer : MonoBehaviour {


	void Start () {
		StartCoroutine (kill ());
	}

	IEnumerator kill ()
	{
		yield return new WaitForSeconds (1.5f);

		Destroy (gameObject);
	}
}

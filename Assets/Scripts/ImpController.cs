using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpController : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}

	void Update () {

		if (Input.GetMouseButtonUp(0)) {
			StartCoroutine (LaunchBolt());
		}
	}

	IEnumerator LaunchBolt(){
		animator.SetTrigger ("ThrowBolt");

		yield return new WaitForSeconds(0.5f);

		gameObject.GetComponentInChildren<BoltLauncher> ().LaunchBolt ();
	}
}

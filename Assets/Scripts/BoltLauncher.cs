using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltLauncher : MonoBehaviour {

	public GameObject bolt;
	public AudioSource boltSound;

	public void LaunchBolt() {
		Instantiate (bolt, transform.position, transform.rotation);
		boltSound.Play ();
	}
}

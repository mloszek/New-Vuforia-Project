using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltLauncher : MonoBehaviour {

	public GameObject bolt;

	public void LaunchBolt() {
		Instantiate (bolt, transform.position, transform.rotation);
	}
}

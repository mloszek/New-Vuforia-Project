using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpController : MonoBehaviour
{

	public GameObject launcher;
	public GameObject chan;
	public AudioSource grunt;
	public AudioSource explosion;
	public AudioSource guts;

	private Animator animator;

	void Start ()
	{
		animator = GetComponent<Animator> ();
		grunt.Play ();
	}

	void Update ()
	{

//		if (Input.GetMouseButtonUp (0)) {
//			StartCoroutine (LaunchBolt ());
//			StartCoroutine (FuckUp ());
//		}
	}

	IEnumerator LaunchBolt ()
	{
		
		animator.SetTrigger ("ThrowBolt");

		yield return new WaitForSeconds (0.5f);

		launcher.GetComponent<BoltLauncher> ().LaunchBolt ();
	}

	IEnumerator FuckUp()
	{
		yield return new WaitForSeconds (4f);

		animator.SetTrigger ("Die!");
		explosion.Play ();
		guts.Play ();
		chan.SetActive (true);
	}
}

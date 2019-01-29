using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO : MonoBehaviour {

	Animator anim;
	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		//StartCoroutine (DoSomething);

	}


	IEnumerator DoSomething ()
	{
		yield return new WaitForSeconds(1f);
		Debug.Log ("l'anim se lance");
		anim.SetBool ("GO", true);
	}
}
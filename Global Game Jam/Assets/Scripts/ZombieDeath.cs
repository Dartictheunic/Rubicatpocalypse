using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour {

	public Rigidbody2D chatBody;
	public Animator anime;
	public bool knockedBack;	
	public float veloX;
	public float veloY;
	public bool dead = false;

	void Start()
	{
		chatBody = GetComponent<Rigidbody2D> ();
		anime = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D (	Collider2D coll)
	{
		if (coll.gameObject.tag == "Bullet") {
			GetComponent<CircleCollider2D> ().enabled = false;
			dead = true;
			StartCoroutine ("DoSomething", 0.1f);
		}
	}

	void Update()
	{
		veloX = chatBody.velocity.x;
		veloY = chatBody.velocity.y;
	}


	IEnumerator DoSomething()
	{
		yield return new WaitForSeconds (1f);
		Destroy (gameObject);
	}

}

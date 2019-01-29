using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

	public GameObject bulletPrefab;
	public KeyCode fire;
	public float vitesse = 10;
	public float speed = 100f;
	public float angle1 = 90f;


	void OnTriggerEnter2D (Collider2D coll)
	{	
		if (coll.gameObject.tag == "Wall" || coll.gameObject.tag == "Zombie") {
			Destroy (gameObject);
		}
	}
}
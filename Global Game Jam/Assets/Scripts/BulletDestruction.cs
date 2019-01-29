using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestruction : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.tag == "Bullet") 
		{
			Destroy (gameObject);
		}
	}
}

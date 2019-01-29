using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEscalier : MonoBehaviour {
	private Vector3 tpup;
	// Use this for initialization
	void Start () {
		tpup = new Vector3 (160, 0,0);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player")
		{
			other.GetComponent<Mouvement2D> ().EscalierTrigger ();
		}

		if (other.tag == "Zombie") {
			other.GetComponent<Transform> ().position += tpup;
			other.GetComponent<Pathfinding.AIDestinationSetter> ().Monte ();
		}
	}

}

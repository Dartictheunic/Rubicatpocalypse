using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEscalier2 : MonoBehaviour {

	private Vector3 tpdown;

	// Use this for initialization
	void Start () {
		tpdown = new Vector3 (-160, 0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other2)
	{
		if (other2.tag == "Player")
		{
			other2.GetComponent<Mouvement2D> ().EscalierTrigger2 ();
		}		
		if (other2.tag == "Zombie") {
			other2.GetComponent<Transform> ().position += tpdown;
			other2.GetComponent<Pathfinding.AIDestinationSetter> ().Descend ();
		}
	}

}

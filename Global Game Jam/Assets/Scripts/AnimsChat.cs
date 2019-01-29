using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimsChat : MonoBehaviour {

	Animator animChat;

	public GameObject parent;

	private bool clamse;
	private bool hasclamsed;
	// Use this for initialization
	void Start () {
		animChat = GetComponent<Animator> ();
		clamse = false;
		hasclamsed = false;
	}


	// Update is called once per frame
	void Update () {

		clamse = parent.GetComponent<ZombieDeath> ().dead;

		if (clamse == false && hasclamsed == false)
		{
			animChat.SetFloat ("velocityx", parent.GetComponent<Pathfinding.AIPath>().velocity.x);
			animChat.SetFloat ("velocityy", parent.GetComponent<Pathfinding.AIPath>().velocity.y);
		}

		else if (clamse == true && hasclamsed == false) 
		{

			hasclamsed = true;
			animChat.SetBool ("Mort", true);
			animChat.SetTrigger ("deadcat");
			Debug.Log("Je suis touché");
		}


	}



}

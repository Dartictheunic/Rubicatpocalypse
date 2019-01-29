using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViséeGun : MonoBehaviour {


	private Vector3 mousePos;
	public Transform target;   //Cible souris
	private Vector3 objectPos;
	private float angle;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		mousePos = Input.mousePosition;
		mousePos.z = -20;
		objectPos = Camera.main.WorldToScreenPoint (target.position);   // transform la position en screenspace
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		angle = Mathf.Atan2 (mousePos.y, mousePos.x) * Mathf.Rad2Deg;  // conversion Radian en degré
		transform.rotation = Quaternion.Euler (0, 0, angle); //rotate l'objet

	}
}

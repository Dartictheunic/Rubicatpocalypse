using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {

	public Transform player;
	private float Z = -05f;

	void LateUpdate()
	{
		Vector3 newPosition = player.position;
		newPosition.y = transform.position.y;
		transform.position = newPosition;

		Vector3 newPosition2 = player.position;
		newPosition.x = transform.position.x;
		transform.position = newPosition2;

		Vector3 temp = transform.position;
		temp.z += -10;
		transform.position = temp;
	}
}

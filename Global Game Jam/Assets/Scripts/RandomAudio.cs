using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudio : MonoBehaviour {

	public AudioClip[] clips;
	private int clipIndex;
	private AudioSource randomAudio;
	private bool audioPlaying = false;

	// Use this for initialization
	void Start () {
		randomAudio = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!randomAudio.isPlaying)
		{
			clipIndex = Random.Range (0, clips.Length - 1);
			randomAudio.clip = clips [clipIndex];
			randomAudio.PlayDelayed (Random.Range (20f, 50f));
			Debug.Log ("Nothing playing, we set new audio to" + randomAudio.clip.name);
		}
	}
}

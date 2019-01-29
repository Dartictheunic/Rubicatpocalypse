using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mouvement2D : MonoBehaviour {

	Rigidbody2D body;
	public KeyCode gauche, droite, bas, haut;
	public float speed = 4.5f;
	public float position;
	public Transform Player;
	public GameObject BulletPrefab;
	public Transform one;
	public float vitesseBullet = 100f;
	public GameObject Escalier;
	public GameObject Escalier2;
	private Vector2 TrEscalier;
	private Vector2 TrEscalier2;
	private Vector2 JoueurPos;
	private Vector2 JoueurPos2;
	public bool Rdc;
	public Camera Cam1;
	public Camera Cam2;
	private Vector3 replacement;
	private Vector3 replacement2;
	public Image lifebar;
	private float filllife;
	public Text UIammo;
	public GameObject pute;
	private Image portrait;
	public Sprite portrait1;
	public Sprite portrait2;
	public Sprite portrait25;
	public Sprite portrait3;
	public Sprite portrait4;

	public int currentAmmo = 10;
	public bool munition = true;

	public int health = 1;

	Animator anim;


	// Use this for initialization
	void Start () 
	{
		body = GetComponent<Rigidbody2D> ();
		TrEscalier = new Vector2 (Escalier.transform.position.x,Escalier.transform.position.y);
		TrEscalier2 = new Vector2 (Escalier2.transform.position.x,Escalier2.transform.position.y);
		anim = GetComponent<Animator> ();
		filllife = 1f;
		lifebar.fillAmount = filllife;			
		UIammo.text = currentAmmo.ToString();
		portrait = pute.GetComponent<Image> ();
	}
		
	// Update is called once per frame
	void Update ()
	{
		float walk = Input.GetAxis ("Horizontal");
		float walkV = Input.GetAxis ("Vertical");

			
		if (currentAmmo == 0) 
		{
			munition = false;
			Debug.Log ("Munition = false");
		}

		//vérification des
		//déplacement 4 axes
		if (Rdc == true && transform.position.x < 100)
		{
			body.velocity = new Vector2 (walkV * speed, body.velocity.y);
			body.velocity = new Vector2 (walk * speed, body.velocity.x);		
			anim.SetFloat ("xvelocity", body.velocity.x);
			anim.SetFloat ("yvelocity", body.velocity.y);
		}

		if (Rdc == false && transform.position.x > 100)
		{
			body.velocity = new Vector2 (walkV * speed, body.velocity.y);
			body.velocity = new Vector2 (walk * speed, body.velocity.x);	
		}


		if (Input.GetMouseButtonDown (0) && munition == true) 
		{
			GameObject clone;
			clone = Instantiate (BulletPrefab, one.position, transform.rotation);
			clone.GetComponent<Rigidbody2D> ().velocity = (one.position - transform.position ).normalized * vitesseBullet;
			currentAmmo--;
			UIammo.text = currentAmmo.ToString();
			Debug.Log ("munition = true");
		}



	}

	public void EscalierTrigger()
	{
		JoueurPos = new Vector2 (transform.position.x, transform.position.y);
		replacement = new Vector3 (7, 0, 0);
		transform.position = Vector2.Lerp (JoueurPos, TrEscalier, 1f);		
		body.Sleep ();
		GameObject.Find ("Player (1)").GetComponent<Mouvement2D> ().body.WakeUp ();
		Rdc = false;
		GameObject.Find ("Player (1)").GetComponent<Mouvement2D> ().Rdc = false;
		Cam1.enabled = !Cam1.enabled;
		Cam2.enabled = !Cam2.enabled;
		GameObject.Find ("Player (1)").GetComponent<Transform> ().position += replacement;
	}

	public void EscalierTrigger2()
	{
		JoueurPos2 = new Vector2 (transform.position.x, transform.position.y);
		replacement2 = new Vector3 (-7, 0, 0);
		transform.position = Vector2.Lerp (JoueurPos2, TrEscalier2, 1f);	
		body.Sleep ();		
		GameObject.Find ("Player").GetComponent<Mouvement2D> ().body.WakeUp ();
		Rdc = true;
		GameObject.Find ("Player").GetComponent<Mouvement2D> ().Rdc = true;
		Cam1.enabled = !Cam1.enabled;
		Cam2.enabled = !Cam2.enabled;
		GameObject.Find ("Player").GetComponent<Transform> ().position += replacement2;
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.tag == "Zombie") 
		{
			health = health - 1;
			CheckVie ();
			Debug.Log ("Vie perdue");
			filllife = health / 8f;
			lifebar.fillAmount = filllife;

			Vector3 direction = (transform.position - coll.transform.position - transform.position).normalized;
			body.AddForce (direction * speed);
		}
	}


	void CheckVie()
	{		
		if (health == 8)
		portrait.sprite = portrait1;

		if (health == 7 || health == 6)
			portrait.sprite = portrait2;

		if (health == 5 || health == 4)
			portrait.sprite = portrait25;

		if (health == 3 || health == 2)
			portrait.sprite = portrait3;

		if (health == 1)
			portrait.sprite = portrait4;


		if (health <= 0) 
		{
			anim.SetTrigger ("death");
			Destroy (gameObject, 3f);
			Debug.Log ("Joueur détruit");
		}
	}

  }

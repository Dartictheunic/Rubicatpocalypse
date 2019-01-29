using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCode : MonoBehaviour {

	public string[] cheatCode;
	public string[] cheatCode2;
	public string[] cheatCode3;
	public string[] cheatCode4;
	public string[] cheatCode5;
	public string[] cheatCode6;
	public string[] cheatCode7;
	public string[] cheatCode8;

	public int index;
	public int index2;
	public int index3;
	public int index4;
	public int index5;
	public int index6;
	public int index7;
	public int index8;

	private bool p = false;
	private bool a = false;
	private bool m = false;
	private bool l = false;
	private bool b = false;
	private bool k = false;
	private bool i = false;
	private bool o = false;

	private int waw;
	private bool wawC = false;
	private bool win = false;

	public GameObject coffre;


	void Awake() {
		// Le Code est "test"
		cheatCode = new string[] { "1", "p", "o", "w", "e","r"};
		cheatCode2 = new string[] { "2","a", "s", "p", "i", "r", "i", "n", "e" };
		cheatCode3 = new string [] { "3","m", "u", "n", "i", "t", "i", "o", "n" };
		cheatCode4 = new string [] { "4","l", "i", "f", "e" };
		cheatCode5 = new string [] { "5","b", "i", "g", "b", "a", "n", "g" };
		cheatCode6 = new string [] { "6","k", "i", "l", "l" };
		cheatCode7 = new string [] { "7","i", "g", "e", "v", "q", "q" };
        cheatCode8 = new string[] { "8", "c", "e", "s", "t", "l", "a", "f", "i", "n" };
        index = 0; 
		index2 = 0;
		index3 = 0;
		index4 = 0;
		index5 = 0;
		index6 = 0;
		index7 = 0;
		index8 = 0;

	}

	void Update() {
		// Vérifie si des touches sont préssées
		if (Input.anyKeyDown)
		{
			if (Input.GetKeyDown(cheatCode[index])) 
			{
				p = true;
			}

			if (Input.GetKeyDown(cheatCode2[index2])) 
			{
				a = true;
			}

			if (Input.GetKeyDown(cheatCode3[index3])) 
			{
				m = true;
			}

			if (Input.GetKeyDown(cheatCode4[index4])) 
			{
				l = true;
			}

			if (Input.GetKeyDown(cheatCode5[index5])) 
			{
				b = true;
			}

			if (Input.GetKeyDown(cheatCode6[index6])) 
			{
				k = true;
			}

			if (Input.GetKeyDown(cheatCode7[index7])) 
			{
				i = true;
			}

			if (Input.GetKeyDown(cheatCode8[index8])) 
			{
				o = true;
			}
		}

		if (p == true)
			{
			index++;
			index2 = 0;
			index3 = 0;
			p = false;
			}
			
		if (a == true)
		{
			index2++;
			index = 0;
			index3 = 0;
			a = false;
		}

		if (m == true)
		{
			index3++;
			index = 0;
			index2 = 0;
			m = false;
		}

		if (l == true)
		{
			index4++;
			l = false;
		}

		if (b == true)
		{
			index5++;
			b = false;
		}

		if (k == true)
		{
			index6++;
			k = false;
		}

		if (i == true)
		{
			index7++;
			i = false;
		}


		if (o == true)
		{
			index8++;
			o = false;
		}
		// Si l'index arrive a sa taille totale
		// Le bon code a été entré

		if (index == cheatCode.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("qhep");
			index = 0;
			cheatCode = new string[] { "4","2","4" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().currentAmmo += 30;
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().munition = true;
			GameObject.Find ("coffre Bleu Ammo 1").GetComponent<Animator> ().SetBool ("Power", true);
			GameObject.Find ("coffre Bleu Ammo 1").GetComponent<Animator> ().SetBool ("Ammo", true);
			waw++;
			Debug.Log (waw);
			}

		if (index2 == cheatCode2.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("aspirine");
			index2 = 0;
			cheatCode2 = new string[] { "5","8","1" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().health += 4;
			GameObject.Find ("Coffre Rouge Vie 1").GetComponent<Animator> ().SetBool ("Vie", true);
			waw++;
			Debug.Log (waw);
			}

		if (index3 == cheatCode3.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("munition");
			index3 = 0;
			cheatCode3 = new string[] { "9","5","0" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().currentAmmo += 30;
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().munition = true;
			GameObject.Find ("coffre Bleu Ammo 2").GetComponent<Animator> ().SetBool ("Power2", true);
			waw++;
			Debug.Log (waw);

		}

		if (index4 == cheatCode4.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("life");
			index4 = 0;
			cheatCode4 = new string[] { "9","5","0" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().health += 4;
			GameObject.Find ("Coffre Rouge Vie 2").GetComponent<Animator> ().SetBool ("Vie2", true);
			waw++;
			Debug.Log (waw);
		}

		if (index5 == cheatCode5.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("bigbang");
			index5 = 0;
			cheatCode4 = new string[] { "9","5","0" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().currentAmmo += 30;
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().munition = true;
			GameObject.Find ("coffre Bleu Ammo 3").GetComponent<Animator> ().SetBool ("Power3", true);
			waw++;
			Debug.Log (waw);
		}

		if (index6 == cheatCode6.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("kill");
			index6 = 0;
			cheatCode6 = new string[] { "9","5","0" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().currentAmmo += 30;
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().munition = true;
			GameObject.Find ("coffre Bleu Ammo 4").GetComponent<Animator> ().SetBool ("Power4", true);
			waw++;
			Debug.Log (waw);
		}

		if (index7 == cheatCode7.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("igevqq");
			index7 = 0;
			cheatCode7 = new string[] { "9","5","0" };
			GameObject.Find ("Player").GetComponent<Mouvement2D> ().health += 4;
			GameObject.Find ("Coffre Rouge Vie 3").GetComponent<Animator> ().SetBool ("Vie3", true);
			waw++;
			Debug.Log (waw);
		}

		if (index8 == cheatCode8.Length) {
			// Bien joué tu as le cheat code
			// Unlock le cheat code
			Debug.Log ("C'est gagné!");
			index8 = 0;
			win = true;
		}
		

		if (waw >= 6)
		{
			coffre.SetActive (true);
			Debug.Log ("Coffre Vert Apparu");
		}

		if (win == true) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
			Debug.Log ("Charge scene de fin");
		}
	}
}
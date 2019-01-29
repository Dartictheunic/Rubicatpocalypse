using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart : MonoBehaviour
{

    void OnGUI()
    {

        if (GUI.Button(new Rect(Screen.width - ((Screen.width / 60)) - (Screen.width / 10), Screen.height /1.15f , Screen.width / 10, Screen.width / 15), "Restart"))  //Création du bouton
        {
            Application.LoadLevel(Application.loadedLevel); //Rechargement du niveau
        }
    }
}
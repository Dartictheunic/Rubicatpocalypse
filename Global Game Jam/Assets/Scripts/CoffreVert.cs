using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffreVert : MonoBehaviour
{



    public string[] cheatCode0;

    public int index0;

    private bool p = false;

    private void Awake()
    {

        cheatCode0 = new string[] { "à", "c", "'", "e", "s", "t", "g", "a", "g", "n", "é", "!" };
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(cheatCode0[index0]))
            {
                p = true;
            }

        }


        if (p == true)
        {
            index0++;
            p = false;
            Debug.Log("c'est la fin");
        }


        if (index0 == cheatCode0.Length)
        {
            Debug.Log("g g à tous!");
            index0 = 0;
            cheatCode0 = new string[] { "4", "2", "4" };
        }
     }
 }

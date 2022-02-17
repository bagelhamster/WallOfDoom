using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthminus : MonoBehaviour
{

    void Start()
    {

    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            GameControlScript.health -= 1;
        }
    }
}
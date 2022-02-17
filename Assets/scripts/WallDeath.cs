using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            GameControlScript.health -= 1;
        }
    }
}

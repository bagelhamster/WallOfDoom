using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butty : MonoBehaviour
{
    public GameObject Win, MainMenu2;
    // Start is called before the first frame update
    void Start()
    {
        Win.gameObject.SetActive(false);
        MainMenu2.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        Win.gameObject.SetActive(true);
        MainMenu2.gameObject.SetActive(true);
        Time.timeScale = 0;

    }



}

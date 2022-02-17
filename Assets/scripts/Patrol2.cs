using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol2 : MonoBehaviour
{
    public float speed;
    public float rayDist;
    private bool movingUp;
    public Transform groundDetect;



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(groundDetect.position, Vector2.down, rayDist);


        if (groundCheck.collider == false)
        {
            if (movingUp == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingUp = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingUp = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovementByRigidbody : MonoBehaviour
{
   public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float speed = 10f;
    public float jump = 10f;
 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (rb.velocity.x > 0)
        {
            sr.flipX = false;
        }
        if (rb.velocity.x < 0)
        {
            sr.flipX = true;
        }

        if (Input.GetButtonDown("Jump") && rb.velocity.y ==0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
    }
}

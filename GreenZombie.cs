using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenZombie : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sr.flipX = true;
    }
}

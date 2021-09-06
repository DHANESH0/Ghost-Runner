using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMover : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;

    private float width;
    float scrollSpeed = -2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

        width = bc.size.x;
        bc.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }

    }
}

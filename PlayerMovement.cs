using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 7f;
    [SerializeField] float JumpForce = 10f;
    private float MoveX;
    private bool isGrounded = true;
    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator Anim;
    AudioSource aus;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
        aus = GetComponent<AudioSource>();

        StartCoroutine(TimerTime());
    }

    // Update is called once per frame
    void Update()
    {
        Playermovement();
        Playerjump();
    }
    private void FixedUpdate()
    {
      
    }

    public void Playermovement()
    {
        MoveX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(MoveX, 0f, 0f) * Time.deltaTime * speed;

        if (MoveX < 0) 
        {
            sr.flipX = true;
            Anim.SetBool("Run", true);
            
        }// left
        if(MoveX == 0)
        {
            Anim.SetBool("Run", false);
        }
        else if (MoveX > 0)
        {
            sr.flipX = false;
            Anim.SetBool("Run", true);
        }//right

    }

    public void Playerjump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * JumpForce;
            aus.Play();
            Anim.SetBool("Jump", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Anim.SetBool("Jump", false);
        }
    }

    IEnumerator TimerTime()
    {
        yield return new WaitForSeconds(30f);
        SceneManager.LoadScene(5);
    }
}

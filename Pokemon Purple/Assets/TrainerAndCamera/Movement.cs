using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    float movespeed = 4f;
    public SpriteRenderer sr;
    public Sprite leftIdle;
    public Sprite rightIdle;
    public Sprite upIdle;
    public Sprite downIdle;
    private string currDirection;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = upIdle;
        currDirection = "Left";
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(- movespeed, 0, 0);
            sr.sprite = leftIdle;
            anim.SetInteger("TrainerWalking", 3);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, movespeed, 0);
            sr.sprite = upIdle;
            anim.SetInteger("TrainerWalking", 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0,- movespeed,0);
            sr.sprite = downIdle;
            anim.SetInteger("TrainerWalking", 2);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3( movespeed,0, 0);
            sr.sprite = rightIdle;
            anim.SetInteger("TrainerWalking", 1);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = new Vector3(transform.position.x + movespeed,
                                             transform.position.y - 10, transform.position.z);
    }
}


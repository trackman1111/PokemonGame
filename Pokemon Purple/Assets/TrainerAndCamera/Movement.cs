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
    private int currDirection;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = upIdle;
        currDirection = 0;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.enabled = true;
            rb.velocity = new Vector3(0, movespeed, 0);
            anim.SetInteger("TrainerWalking", 0);
            currDirection = 0;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.enabled = true;
            rb.velocity = new Vector3(movespeed, 0, 0);
            anim.SetInteger("TrainerWalking", 1);
            currDirection = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.enabled = true;
            rb.velocity = new Vector3(0, -movespeed, 0);
            anim.SetInteger("TrainerWalking", 2);
            currDirection = 2;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.enabled = true;
            rb.velocity = new Vector3(-movespeed, 0, 0);
            anim.SetInteger("TrainerWalking", 3);
            currDirection = 3;
        }
        else
        {
            anim.enabled = false;
            if (currDirection == 0)
            {
                sr.sprite = upIdle;
            }
            else if (currDirection == 1)
            {
                sr.sprite = rightIdle;
            }
            else if (currDirection == 2)
            {
                sr.sprite = downIdle; ;
            }
            else if (currDirection == 3)
            {
                sr.sprite = leftIdle;
            }
            rb.velocity = new Vector3(0, 0, 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = new Vector3(transform.position.x + movespeed,
                                             transform.position.y - 10, transform.position.z);
    }
}


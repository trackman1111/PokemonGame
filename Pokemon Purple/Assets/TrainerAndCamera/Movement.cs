using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sr;
    public Sprite leftIdle;
    public Sprite rightIdle;
    public Sprite upIdle;
    public Sprite downIdle;
    public Tilemap walkable;
    public Sprite bush;
    private Vector3 desiredPosition;
    private Vector3 previousPosition;
    private int currDirection;
    private float interpolationSpeed = 5F;
    private bool stasis = false;

    // Start is called before the first frame update
    void Start()
    {
        desiredPosition = transform.position;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = upIdle;
        currDirection = 0;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    void Update()
    {
        if (walkable.GetSprite(new Vector3Int((int)(transform.position.x - .5), (int)transform.position.y - 1, 0)).Equals(bush))
        {
            print("ONBUSH");
        }
        else
        {
            print("NOT BUSH");
        }
        if (stasis == false )
        {
            anim.enabled = true;
            KeyInput();
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, interpolationSpeed * Time.deltaTime);
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
    void KeyInput()
    {
        if (transform.position == desiredPosition)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.enabled = true;
                desiredPosition += Vector3.up;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 0);
                currDirection = 0;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                anim.enabled = true;
                desiredPosition += Vector3.right;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 1);
                currDirection = 1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.enabled = true;
                desiredPosition += Vector3.down;
                previousPosition = transform.position;
                anim.SetInteger("TrainerWalking", 2);
                currDirection = 2;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.enabled = true;
                desiredPosition += Vector3.left;
                previousPosition = transform.position;
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

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(currDirection == 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - .1f);
            desiredPosition = previousPosition;
        }
        if (currDirection == 1)
        {
            transform.position = new Vector2(transform.position.x - .1f, transform.position.y);
            desiredPosition = previousPosition;
        }
        if (currDirection == 2)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + .1f);
            desiredPosition = previousPosition;
        }
        if (currDirection == 3)
        {
            transform.position = new Vector2(transform.position.x + .1f, transform.position.y);
            desiredPosition = previousPosition;
        }


    }
    public void setStasis(bool given)
    {
        stasis = given;
    }
}


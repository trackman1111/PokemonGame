using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float movespeed = .1f;
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
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - movespeed,
                                             transform.position.y, transform.position.z);
            sr.sprite = leftIdle;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y + movespeed, transform.position.z);
            sr.sprite = upIdle;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y - movespeed, transform.position.z);
            sr.sprite = downIdle;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + movespeed,
                                             transform.position.y, transform.position.z);
            sr.sprite = rightIdle;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = new Vector3(transform.position.x + movespeed,
                                             transform.position.y -10, transform.position.z);
    }
}


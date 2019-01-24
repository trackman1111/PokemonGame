using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite downSprite;
    public Sprite upSprite;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x -.1f,
                                             transform.position.y, transform.position.z);
            this.GetComponent<SpriteRenderer>().sprite = leftSprite;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y + .1f, transform.position.z);
            this.GetComponent<SpriteRenderer>().sprite = upSprite;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y - .1f, transform.position.z);
            this.GetComponent<SpriteRenderer>().sprite = downSprite;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + .1f,
                                             transform.position.y, transform.position.z);
            this.GetComponent<SpriteRenderer>().sprite = rightSprite;
        }

    }
}

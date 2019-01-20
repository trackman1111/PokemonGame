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
            transform.Translate(Vector3.left * Time.deltaTime * 3);
            this.GetComponent<SpriteRenderer>().sprite = leftSprite;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 3);
            this.GetComponent<SpriteRenderer>().sprite = upSprite;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 3);
            this.GetComponent<SpriteRenderer>().sprite = downSprite;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3);
            this.GetComponent<SpriteRenderer>().sprite = rightSprite;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemjaunt : MonoBehaviour
{
    public Trainer trainer;
    ArrayList bag;
    bool isTouching;

    // Start is called before the first frame update
    void Start()
    {
        isTouching = false;

        bag = trainer.bag;
    }

    // Update is called once per frame
    void Update()
    {
        if ( isTouching && Input.GetKeyDown(KeyCode.Y) )
        {
            bag.Add("Pokeball");
            print("pokeball added");
        }
        else if ( isTouching && Input.GetKeyDown(KeyCode.Y))
        {
            print("okie");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Would you like to pickup the pokeball? (Y/N)");
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        isTouching = false;
    }
}

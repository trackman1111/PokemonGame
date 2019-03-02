using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClass : MonoBehaviour
{
    public Trainer trainer;
    public Movement movement;

    bool answered;

    // Start is called before the first frame update
    void Start()
    {
        movement.GetComponent<Movement>();
        answered = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ( !answered )
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                trainer.bag.Add("Pokeball");
                answered = true;
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                answered = true;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Would you like to pickup the pokeball? (Y/N)");
        answered = false;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {

    }
}

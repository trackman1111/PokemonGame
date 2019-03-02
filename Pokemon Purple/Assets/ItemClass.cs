using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClass : MonoBehaviour
{
    public Trainer trainer;
    public string name;
 // public Movement movement;
    int added = 0;
    bool answered;
    string itemName;
    // Start is called before the first frame update
    void Start()
    {
   //     movement.GetComponent<Movement>();
        answered = true;
        itemName = name;
    }

    // Update is called once per frame
    void Update()
    {
        if ( !answered && added == 0 )
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                trainer.bag.Add(itemName);
                print("You have added " + name + " to your Bag!");
                answered = true;
                added++;
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                answered = true;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Movement>().setStasis(true);
        if ( added == 0 )
        {
            print("Would you like to pickup the " + itemName + "? (Y/N)");
            answered = false;
        }
        else
        {
            print("This Pokeball has already been opened!");
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        FindObjectOfType<Movement>().setStasis(false);
    }
}

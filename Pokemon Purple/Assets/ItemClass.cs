using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClass : MonoBehaviour
{
    public Trainer trainer;
    public string name;
 // public Movement movement;
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
        if ( !answered )
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                trainer.bag.Add(itemName);
                print("You have added " + name + " to your Bag!");
                answered = true;

                Destroy(this.gameObject);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                answered = true;
                Destroy(this.gameObject);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Movement>().setStasis(true);
        print("Would you like to pickup the " + itemName + "? (Y/N)");
        answered = false;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        FindObjectOfType<Movement>().setStasis(false);
    }
}

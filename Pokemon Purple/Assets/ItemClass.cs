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
    public Dialogue dialogue;
    public DialogueController dialogueController;
    // Start is called before the first frame update
    void Start()
    {
   //     movement.GetComponent<Movement>();
        itemName = name;
    }

    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
        string[] textToDialogue = { "You have added " + name + " to your Bag!" };
        dialogueController.StartDialogue(new Dialogue(itemName, textToDialogue));
        answered = false;
        trainer.bag.Add(itemName);
        answered = true;
        Destroy(this.gameObject);
    }

}

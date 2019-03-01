using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueController dialogueController;
    public Movement movement;
    private Collider2D collider;
    private bool isTouching;
    public void triggerDialogue()
    {
        dialogueController.StartDialogue(dialogue);
    }
    public void Start()
    {
        collider = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
        isTouching = false;

    }
    
    public void Update()
    {
        //if (isTouching == true /*&& Input.GetKeyDown(KeyCode.E)*/ )
       // {
            //triggerDialogue();
            //isTouching = false;
        //}
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //isTouching = true;
        triggerDialogue();
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        //isTouching = false;
    }
}

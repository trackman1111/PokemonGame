using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    public Movement movement;
    private Collider2D collider;
    private Collider2D collider2;
    public void triggerDialogue()
    {
        FindObjectOfType<DialogueController>().StartDialogue(dialogue);
    }
    public void Start()
    {
        collider2 = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
        collider2 = movement.getCollider();

    }
    /*
    public void Update()
    {
        if (collider2.IsTouching(collider) && Input.GetKeyDown(KeyCode.E) )
        {
            triggerDialogue();
        }
    }
    */
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //if ( Input.GetKeyDown(KeyCode.E) )
        //{
            triggerDialogue();
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueController dialogueController;
    public Movement movement;
    public bool isTrainer;
    private CanvasManager canMan;
    private Collider2D colliderTwoD;
    public GameObject optionsMenuController;
    private PokemonData pokeData;
    private string pokeName;
    private bool isFinished;
    public void triggerDialogue()
    {
        dialogueController.StartDialogue(dialogue);
        if ( isTrainer == true )
        {
            moveToBattle();
        }

    }
    public void Start()
    {
        colliderTwoD = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
        canMan = optionsMenuController.GetComponent<CanvasManager>();
        pokeData = new PokemonData();
        isFinished = false;
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
        isFinished = false;
        triggerDialogue();
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        //isTouching = false;
    }
    public void moveToBattle()
    {
        canMan.startBattle(firstPokemon());
        print("move to battle");
    }
    public Pokemon firstPokemon()
    {
        pokeName = pokeData.getWildPokemon();
        return new Pokemon(pokeName);
        print("movetobattle");
    }
    public void setFinished(bool given)
    {
        isFinished = given;
    }
}


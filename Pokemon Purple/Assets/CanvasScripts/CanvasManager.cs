﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject bag;
    public GameObject pokemon;
    public GameObject battle;
    public GameObject pokeCenter;
    public GameObject blackScreen;
    public GameObject helpMenu;
    private bool caught;
    private WaitForSeconds timer;
    //private bool isPokeCenterOpen;
    private bool inBattle;
    private int iterations;

    // Start is called before the first frame update
    void Start()
    {
        bag.SetActive(false);
        menu.SetActive(false);
        inBattle = false;
        iterations = 0;
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown("escape") && !inBattle)
        {
            if (menu.activeSelf)
            {
                menu.SetActive(false);
                FindObjectOfType<Movement>().setStasis(false);
            }
            else if ( bag.activeSelf )
            {
                bag.SetActive(false);
                menu.SetActive(true);
            }
            else if (pokemon.activeSelf)
            {
                pokemon.SetActive(false);
                menu.SetActive(true);
            }
            else if (helpMenu.activeSelf)
            {
                helpMenu.SetActive(false);
                menu.SetActive(true);
            }
            else
            {
                menu.SetActive(true);
                FindObjectOfType<Movement>().setStasis(true);
            }
        }
        else if ( inBattle && ( iterations == 3 ) )
        {
            menu.SetActive(false);
            bag.SetActive(false);
            pokemon.SetActive(false);
            battle.SetActive(true);
            iterations = 0;
        }
        else if (inBattle && (iterations == 0))
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menu.SetActive(false);
                bag.SetActive(false);
                pokemon.SetActive(false);
                battle.SetActive(true);
            }
        }
        else
        {
            battle.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            pokeCenter.SetActive(true);
        }


    }
    public void startBattle()
    {
        FindObjectOfType<Movement>().setStasis(true);
        fadeScreen();
        inBattle = true;
    }

    void fadeScreen()
    {
        Invoke("turnOnBlack", 0.25f);
        Invoke("turnOffBlack", 0.5f );
        Invoke("turnOnBlack", 0.75f);
        Invoke("turnOffBlack", 1.0f);
        Invoke("turnOnBlack", 1.25f);
        Invoke("turnOffBlack", 1.5f);

    }

    IEnumerator MyMethod()
    {
        Debug.Log("Before Waiting 1 seconds");
        blackScreen.SetActive(true);
        yield return new WaitForSeconds( 1 );
        blackScreen.SetActive(false);
        Debug.Log("After Waiting 1 Seconds");
    }

    void turnOnBlack()
    {
        blackScreen.SetActive(true);
    }

    void turnOffBlack()
    {
        blackScreen.SetActive(false);
        iterations++;
    }

    public void exitBattle()
    {
        battle.SetActive(false);
        pokemon.SetActive(false);
        bag.SetActive(false);
        inBattle = false;
        FindObjectOfType<Movement>().setStasis(false);
    }
    public void catchPokemon()
    {
        caught = true;
        exitBattle();

    }
    public bool getCaught()
    {
        return caught;
    }
    public void setCaught(bool a)
    {
        caught = a;
    }

    public void bagBattle()
    {
        bag.SetActive(true);
    }
    public void pokemonBattle()
    {
        pokemon.SetActive(true);
    }
    void fight()
    {
        print("fight");
    }

}

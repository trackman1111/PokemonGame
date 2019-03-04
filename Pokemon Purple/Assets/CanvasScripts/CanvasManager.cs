using System.Collections;
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
            else
            {
                menu.SetActive(true);
                FindObjectOfType<Movement>().setStasis(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            FindObjectOfType<Movement>().setStasis(true);
            fadeScreen();
            inBattle = true;
        }
        if ( inBattle && ( iterations == 2 ) )
        {
            menu.SetActive(false);
            bag.SetActive(false);
            pokemon.SetActive(false);

            battle.SetActive(true);
            if (Input.GetKeyDown("escape"))
            {
                bag.SetActive(false);
                pokemon.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            pokeCenter.SetActive(true);
        }


    }

    void fadeScreen()
    {
        Invoke("turnOnBlack", 0.5f);
        Invoke("turnOffBlack", 1.0f );
        Invoke("turnOnBlack", 1.5f);
        Invoke("turnOffBlack", 2.0f);

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

    void run()
    {
        battle.SetActive(false);
        pokemon.SetActive(false);
        bag.SetActive(false);
    }
    void bagBattle()
    {

        bag.SetActive(true);
    }
    void fight()
    {
        print("fight");
    }
    void pokemonBattle()
    {
        pokemon.SetActive(true);
    }

}

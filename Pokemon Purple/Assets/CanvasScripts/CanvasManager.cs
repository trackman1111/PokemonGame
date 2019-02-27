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
    //private bool isPokeCenterOpen;
    private bool inBattle;

    // Start is called before the first frame update
    void Start()
    {
        bag.SetActive(false);
        menu.SetActive(false);
        inBattle = false;
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown("escape") && !inBattle)
        {
            if (menu.activeSelf)
            {
                menu.SetActive(false);
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
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            inBattle = true;
        }
        if ( inBattle )
        {
            menu.SetActive(false);
            bag.SetActive(false);
            pokemon.SetActive(false);
            battle.SetActive(true);
            if (Input.GetKeyDown("esc"))
            {
                bag.SetActive(false);
                pokemon.SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            pokeCenter.SetActive(true);
        }
       // if(Input.GetKeyDown(KeyCode.K) && pokeCenter.)
       // {
        //    pokeCenter.SetActive(false);
       // }

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

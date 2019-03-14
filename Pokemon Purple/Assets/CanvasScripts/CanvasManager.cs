using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject bag;
    public GameObject pokemon;
    public GameObject battle;
    public GameObject pokeCenter;
    public GameObject blackScreen;
    public GameObject helpMenu;
    public Image enemyImage;
    private BattleCanvasScript battleCanvas;

    public Trainer t;
    public TextMeshProUGUI enemy;

    private bool caught;
    private WaitForSeconds timer;
    //private bool isPokeCenterOpen;
    private bool inBattle;
    private int iterations;
    private string enemyName;

    // Start is called before the first frame update
    void Start()
    {
        bag.SetActive(false);
        menu.SetActive(false);
        inBattle = false;
        iterations = 1;
        battleCanvas = battle.GetComponent<BattleCanvasScript>();
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
        else if ( inBattle && ( iterations == 4 ) )
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
    public void startBattle( Pokemon wildPokemon )
    {
        if ( t.pokemon[0] != null )
        {
            FindObjectOfType<Movement>().setStasis(true);
            fadeScreen();
            inBattle = true;
            iterations = 1;
            battleCanvas.setEnemy(wildPokemon);
            // 
            Pokemon temp = t.pokemon[0];
            print(temp.moveOne);
            print(temp.moveTwo);
            print(temp.moveThree);
            print(temp.moveFour);
        }
        else
        {
            print("You have no pokemon so you ran.");
        }
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
    public void bagBattle()
    {
        bag.SetActive(true);
    }
    public void pokemonBattle()
    {
        pokemon.SetActive(true);
    }
}

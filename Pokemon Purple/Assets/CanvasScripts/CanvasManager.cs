using System.Collections;
using System.Collections.Generic;
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

    public Sprite tree;
    public Sprite grov;
    public Sprite scep;
    public Sprite torc;
    public Sprite comb;
    public Sprite blaz;
    public Sprite mudk;
    public Sprite mars;
    public Sprite swam;
    public Sprite pooc;
    public Sprite migh;
    public Sprite zigz;
    public Sprite lino;
    public Sprite kyog;
    public Sprite grou;
    public Sprite rayq;
    public Sprite other;

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

            // BATTLE CODE HERE

           enemyImage.sprite = getImage( enemyName );

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
    public void startBattle( string tempName )
    {
        enemyName = tempName;
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

    public Sprite getImage(string name)
    {
        if (name.Equals("Treecko"))
        {
            return tree;
        }
        else if (name.Equals("Grovyle"))
        {
            return grov;
        }
        else if (name.Equals("Sceptile"))
        {
            return scep;
        }
        else if (name.Equals("Torchic"))
        {
            return torc;
        }
        else if (name.Equals("Combusken"))
        {
            return comb;
        }
        else if (name.Equals("Blaziken"))
        {
            return blaz;
        }
        else if (name.Equals("Mudkip"))
        {
            return mudk;
        }
        else if (name.Equals("Marshtomp"))
        {
            return mars;
        }
        else if (name.Equals("Swampert"))
        {
            return swam;
        }
        else if (name.Equals("Poochyena"))
        {
            return pooc;
        }
        else if (name.Equals("Mightyena"))
        {
            return migh;
        }
        else if (name.Equals("Zigzagoon"))
        {
            return zigz;
        }
        else if (name.Equals("Linoone"))
        {
            return lino;
        }
        else if (name.Equals("Kyogre"))
        {
            return kyog;
        }
        else if (name.Equals("Groudon"))
        {
            return grou;
        }
        else if (name.Equals("Rayquaza"))
        {
            return rayq;
        }
        else
        {
            return other;
        }
    }
}

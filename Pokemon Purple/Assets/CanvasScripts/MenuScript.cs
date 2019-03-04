using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject bag;
    public GameObject menu;
    public GameObject pokemon;
    public GameObject help;

    public Text pokedexText;
    public Text pokemonText;
    public Text bagText;
    public Text saveText;
    public Text helpText;
    public Text exitText;

    int counter = 1;
    ArrayList menuList = new ArrayList();

    void Start()
    {
        menuList.Add(pokedexText);
        menuList.Add(pokemonText);
        menuList.Add(bagText);
        menuList.Add(saveText);
        menuList.Add(exitText);

        pokedexText.text = "  POKEDEX";
        pokemonText.text = "  POKEMON";
        bagText.text = "  BAG";
        saveText.text = "  SAVE";
        helpText.text = "  HELP";
        exitText.text = "  EXIT";
    }

    void Update()
    {
        if ( menu.activeSelf )
        {
            if (counter == 0 && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow)))
            {
                counter = 1;
            }
            else if ( counter < 6 && Input.GetKeyDown(KeyCode.DownArrow) )
            {
                counter++;

                pokedexText.text = "  POKEDEX";
                pokemonText.text = "  POKEMON";
                bagText.text = "  BAG";
                saveText.text = "  SAVE";
                helpText.text = "  HELP";
                exitText.text = "  EXIT";
            }
            else if (counter > 1 && Input.GetKeyDown(KeyCode.UpArrow))
            {
                counter--;

                pokedexText.text = "  POKEDEX";
                pokemonText.text = "  POKEMON";
                bagText.text = "  BAG";
                saveText.text = "  SAVE";
                helpText.text = "  HELP";
                exitText.text = "  EXIT";
            }

            if ( counter == 1 )
            {
                pokedexText.text = "->POKEDEX";
            }
            else if (counter == 2)
            {
                pokemonText.text = "->POKEMON";
            }
            else if (counter == 3)
            {
                bagText.text = "->BAG";
            }
            else if (counter == 4)
            {
                saveText.text = "->SAVE";
            }
            else if (counter == 5)
            {
                helpText.text = "->HELP";
            }
            else if (counter == 6)
            {
                exitText.text = "->EXIT";
            }

            if ( Input.GetKeyDown(KeyCode.RightShift) )
            {
                if(counter == 1)
                {
                    openPokedex();
                }
                else if (counter == 2)
                {
                    openPokemon();
                }
                else if (counter == 3)
                {
                    openBag();
                }
                else if (counter == 4)
                {
                    save();
                }
                else if (counter == 5)
                {
                    openHelp();
                }
                else if (counter == 6)
                {
                    exitGame();
                }
            }
        }
    }

    public void openPokedex()
    {

    }
    public void openPokemon()
    {
        menu.SetActive(false);
        pokemon.SetActive(true);
    }
    public void openBag()
    {
        menu.SetActive(false);
        bag.SetActive(true);
    }
    public void save()
    {
        
    }
    public void openHelp()
    {
        menu.SetActive(false);
        help.SetActive(true);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}

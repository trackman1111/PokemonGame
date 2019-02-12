using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject bag;
    public GameObject menu;
    public GameObject pokemon;

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
    public void exitGame()
    {
        Application.Quit();
    }
}

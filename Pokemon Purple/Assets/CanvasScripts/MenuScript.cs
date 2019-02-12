using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject bag;
    public GameObject menu;

    public void openBag()
    {
        menu.SetActive(false);
        bag.SetActive(true);
    }
    public void openPokedex()
    {

    }
    public void save()
    {

    }
    public void exitGame()
    {
        Application.Quit();
    }
}

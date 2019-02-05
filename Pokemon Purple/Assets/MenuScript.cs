using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    public void playGame()
    {
        menu.SetActive(false);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}

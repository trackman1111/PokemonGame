using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject chooseStarter;
    public void LoadGame()
    {
        print("hello");
    }
    public void StartGame()
    {
        startScreen.SetActive(false);
        chooseStarter.SetActive(true);
    }
    public void ChooseStarters(string poke)
    {
        PlayerPrefs.SetString("Starter", poke);
        SceneManager.LoadScene("MainScene");
    }
}

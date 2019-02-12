using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject menuController;
    public GameObject credits;
    public GameObject bag;

    // Start is called before the first frame update
    void Start()
    {
        bag.SetActive(false);
        menu.SetActive(false);
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (menu.activeSelf)
            {
                menu.SetActive(false);
            }
            else if ( bag.activeSelf )
            {
                bag.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
                menuController.SetActive(true);
                credits.SetActive(false);
            }
        }
    }
}

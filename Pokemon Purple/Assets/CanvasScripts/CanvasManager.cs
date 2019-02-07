using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject menu;
    public GameObject menuController;
    public GameObject credits;
    public GameObject bag;

    public Trainer trainer;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (bag.activeSelf)
            {
                bag.SetActive(false);
            }

            if (menu.activeSelf)
            {
                menu.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
                menuController.SetActive(true);
                credits.SetActive(false);
            }

        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            if ( !menu.activeSelf )
            {
                if (bag.activeSelf)
                {
                    bag.SetActive(false);
                }
                else
                {
                    bag.SetActive(true);
                    menuController.SetActive(true);
                    credits.SetActive(false);
                }
            }

        }
    }
}

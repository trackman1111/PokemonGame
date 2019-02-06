using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{

    public string text;
    public GameObject bag;
    private bool isShowing = true;

    // Start is called before the first frame update
    void Start()
    {

        text = "test";
        

        close();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))                   
        {
            if ( isShowing )
            {
                close();
            }
            else
            {
                open();
            }
            isShowing = !isShowing;
        }
    }

    void open()
    {
        bag.SetActive(true);
    }

    void close()
    {
        bag.SetActive(false);
    }
}

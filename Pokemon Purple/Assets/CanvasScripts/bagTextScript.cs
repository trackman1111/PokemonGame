using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bagTextScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Trainer trainer;

    bool isOpen = true;

    // Start is called before the first frame update
    void Start()
    {
        //  bag = GlobalControl.Instance.bag;
    }

    // Update is called once per frame
    void Update()
    {
        ArrayList bag = trainer.bag;


        if ( isOpen )
        {
            string items = "";

            for (int i = 0; i < bag.Count - 1; i++)
            {
                items += bag[i] + "\n";
            }

            text.text = items;

            isOpen = false; ;
        }
        if ( Input.GetKeyDown(KeyCode.B) )
        {
            isOpen = true;
        }

    }

    void SavePlayer()
    {
        //GlobalControl.Instance.bag = bag;
    }
}

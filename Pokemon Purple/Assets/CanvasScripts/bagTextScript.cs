using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagTextScript : MonoBehaviour
{
    Text text;
    string items;

    ArrayList bag;
    Trainer trainer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.B ) )
        {
            text = GetComponent<Text>();

            bag = trainer.bag;
            print(bag + "1");
        }
    }
}

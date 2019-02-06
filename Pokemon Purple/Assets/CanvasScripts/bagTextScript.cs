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

        trainer = GetComponent<Trainer>();

        bag = trainer.bag;


        for ( int i = 0; i < bag.Count - 2; i++ )
        {
            items += bag[i] + ", ";
        }
        items += bag[ bag.Count - 1 ];

        text.GetComponent<Text>().text = items;
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.B ) )
        {
            bag = trainer.bag;
            print(bag + "1");
        }
    }
}

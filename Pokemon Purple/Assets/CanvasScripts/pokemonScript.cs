using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pokemonScript : MonoBehaviour
{

    public TextMeshProUGUI p1name;
    public TextMeshProUGUI p1lvl;
    public TextMeshProUGUI p1hp;

    public TextMeshProUGUI p2name;
    public TextMeshProUGUI p2lvl;
    public TextMeshProUGUI p2hp;

    public TextMeshProUGUI p3name;
    public TextMeshProUGUI p3lvl;
    public TextMeshProUGUI p3hp;

    public TextMeshProUGUI p4name;
    public TextMeshProUGUI p4lvl;
    public TextMeshProUGUI p4hp;

    public TextMeshProUGUI p5name;
    public TextMeshProUGUI p5lvl;
    public TextMeshProUGUI p5hp;

    public TextMeshProUGUI p6name;
    public TextMeshProUGUI p6lvl;
    public TextMeshProUGUI p6hp;

    public GameObject pokePanel;
    public Trainer trainer;
    string[,] pokemon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( pokePanel.activeSelf )
        {
            pokemon = trainer.pokemon;

            if (pokemon[0, 0].Equals(""))
            {
                p1name.text = "";
                p1lvl.text = "";
                p1hp.text = "";
            }
            else
            {
                p1name.text = pokemon[0, 0];
                p1lvl.text = "lvl";
                p1hp.text = "hp";
            }


            if (pokemon[1, 0].Equals(""))
            {
                p2name.text = "";
                p2lvl.text = "";
                p2hp.text = "";
            }
            else
            {
                p2name.text = pokemon[1, 0];
                p2lvl.text = "lvl";
                p2hp.text = "hp";
            }


            if (pokemon[2, 0].Equals(""))
            {
                p3name.text = "";
                p3lvl.text = "";
                p3hp.text = "";
            }
            else
            {
                p3name.text = pokemon[2, 0];
                p3lvl.text = "lvl";
                p3hp.text = "hp";
            }


            if (pokemon[3, 0].Equals(""))
            {
                p4name.text = "";
                p4lvl.text = "";
                p4hp.text = "";
            }
            else
            {
                p4name.text = pokemon[3, 0];
                p4lvl.text = "lvl";
                p4hp.text = "hp";
            }


            if (pokemon[4, 0].Equals(""))
            {
                p5name.text = "";
                p5lvl.text = "";
                p5hp.text = "";
            }
            else
            {
                p5name.text = pokemon[4, 0];
                p5lvl.text = "lvl";
                p5hp.text = "hp";
            }


            if (pokemon[5, 0].Equals(""))
            {
                p6name.text = "";
                p6lvl.text = "";
                p6hp.text = "";
            }
            else
            {
                p6name.text = pokemon[5, 0];
                p6lvl.text = "lvl";
                p6hp.text = "hp";
            }
        }
    }
}

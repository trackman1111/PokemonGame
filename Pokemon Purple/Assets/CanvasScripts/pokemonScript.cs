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

    Pokemon[] pokemon;

    // Start is called before the first frame update
    void Start()
    {
        p1name.text = "";
        p1lvl.text =  "";
        p1hp.text = "";

        p2name.text = "";
        p2lvl.text = "";
        p2hp.text = "";

        p3name.text = "";
        p3lvl.text = "";
        p3hp.text = "";

        p4name.text = "";
        p4lvl.text = "";
        p4hp.text = "";

        p5name.text = "";
        p5lvl.text = "";
        p5hp.text = "";


        p6name.text = "";
        p6lvl.text = "";
        p6hp.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if ( pokePanel.activeSelf )
        {
            pokemon = trainer.pokemon;

            if (pokemon[0].name.Equals(""))
            {
                p1name.text = "";
                p1lvl.text = "";
                p1hp.text = "";
            }
            else
            {
                p1name.text = pokemon[0].name;
                p1lvl.text = pokemon[0].level + "";
                p1hp.text = pokemon[0].health + "";
            }

            if (pokemon[1].name.Equals(""))
            {
                p2name.text = "";
                p2lvl.text = "";
                p2hp.text = "";
            }
            else
            {
                p2name.text = pokemon[1].name;
                p2lvl.text = pokemon[1].level + "";
                p2hp.text = pokemon[1].health + "";
            }


            if (pokemon[2].name.Equals(""))
            {
                p3name.text = "";
                p3lvl.text = "";
                p3hp.text = "";
            }
            else
            {
                p3name.text = pokemon[2].name;
                p2lvl.text = pokemon[2].level + "";
                p2hp.text = pokemon[2].health + "";
            }


            if (pokemon[3].name.Equals(""))
            {
                p4name.text = "";
                p4lvl.text = "";
                p4hp.text = "";
            }
            else
            {
                p4name.text = pokemon[3].name;
                p2lvl.text = pokemon[3].level + "";
                p2hp.text = pokemon[3].health + "";
            }


            if (pokemon[4].name.Equals(""))
            {
                p5name.text = "";
                p5lvl.text = "";
                p5hp.text = "";
            }
            else
            {
                p5name.text = pokemon[4].name;
                p2lvl.text = pokemon[4].level + "";
                p2hp.text = pokemon[4].health + "";
            }


            if (pokemon[5].name.Equals(""))
            {
                p6name.text = "";
                p6lvl.text = "";
                p6hp.text = "";
            }
            else
            {
                p6name.text = pokemon[5].name;
                p2lvl.text = pokemon[5].level + "";
                p2hp.text = pokemon[5].health + "";
            }
        }
    }
}

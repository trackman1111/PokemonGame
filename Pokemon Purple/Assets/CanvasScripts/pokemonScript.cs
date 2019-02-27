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
    public Image p1image;

    public TextMeshProUGUI p2name;
    public TextMeshProUGUI p2lvl;
    public TextMeshProUGUI p2hp;
    public Image p2image;

    public TextMeshProUGUI p3name;
    public TextMeshProUGUI p3lvl;
    public TextMeshProUGUI p3hp;
    public Image p3image;

    public TextMeshProUGUI p4name;
    public TextMeshProUGUI p4lvl;
    public TextMeshProUGUI p4hp;
    public Image p4image;

    public TextMeshProUGUI p5name;
    public TextMeshProUGUI p5lvl;
    public TextMeshProUGUI p5hp;
    public Image p5image;

    public TextMeshProUGUI p6name;
    public TextMeshProUGUI p6lvl;
    public TextMeshProUGUI p6hp;
    public Image p6image;

    public GameObject pokePanel;
    public Trainer trainer;

    public Sprite tree;
    public Sprite grov;
    public Sprite scep;
    public Sprite torc;
    public Sprite comb;
    public Sprite blaz;
    public Sprite mudk;
    public Sprite mars;
    public Sprite swam;
    public Sprite pooc;
    public Sprite migh;
    public Sprite zigz;
    public Sprite lino;
    public Sprite kyog;
    public Sprite grou;
    public Sprite rayq;
    public Sprite other;

    Pokemon[] pokemon;

    // Start is called before the first frame update
    void Start()
    {
        p1name.text = "";
        p1lvl.text =  "";
        p1hp.text = "";
        p1image.GetComponent<Image>();
        p1image.GetComponent<SpriteRenderer>();

        Color temp = p1image.color;
        temp.a = 0;
        p1image.color = temp;

        p2name.text = "";
        p2lvl.text = "";
        p2hp.text = "";
        p2image.GetComponent<Image>();
        p2image.GetComponent<SpriteRenderer>();
        p2image.color = temp;

        p3name.text = "";
        p3lvl.text = "";
        p3hp.text = "";
        p3image.GetComponent<Image>();
        p3image.GetComponent<SpriteRenderer>();
        p3image.color = temp;

        p4name.text = "";
        p4lvl.text = "";
        p4hp.text = "";
        p4image.GetComponent<Image>();
        p4image.GetComponent<SpriteRenderer>();
        p4image.color = temp;

        p5name.text = "";
        p5lvl.text = "";
        p5hp.text = "";
        p5image.GetComponent<Image>();
        p5image.GetComponent<SpriteRenderer>();
        p5image.color = temp;


        p6name.text = "";
        p6lvl.text = "";
        p6hp.text = "";
        p6image.GetComponent<Image>();
        p6image.GetComponent<SpriteRenderer>();
        p6image.color = temp;
    }

    // Update is called once per frame
    void Update()
    {
        if ( pokePanel.activeSelf )
        {
            pokemon = trainer.pokemon;
 
            if ( pokemon[0].name.Equals("") )
            {
                p1name.text = "";
                p1lvl.text = "";
                p1hp.text = "";

                Color temp = p1image.color;
                temp.a = 0;
                p1image.color = temp;
            }
            else
            {
                p1name.text = pokemon[0].name + "";
                p1lvl.text = "Lvl " + pokemon[0].level;
                p1hp.text = pokemon[0].health + "/" + pokemon[0].currHealth;

                Color temp = p1image.color;
                temp.a = 255;
                p1image.color = temp;
                p1image.sprite = getImage(pokemon[0].name);
            }

            if (pokemon[1].name.Equals("") )
            {
                p2name.text = "";
                p2lvl.text = "";
                p2hp.text = "";

                Color temp = p2image.color;
                temp.a = 0;
                p2image.color = temp;
            }
            else
            {
                p2name.text = pokemon[1].name;
                p2lvl.text = "Lvl " + pokemon[1].level;
                p2hp.text = pokemon[1].health + "/" + pokemon[1].currHealth;

                Color temp = p2image.color;
                temp.a = 255;
                p2image.color = temp;
                p2image.sprite = getImage(pokemon[1].name);
            }


            if (pokemon[2].name.Equals(""))
            {
                p3name.text = "";
                p3lvl.text = "";
                p3hp.text = "";

                Color temp = p3image.color;
                temp.a = 0;
                p3image.color = temp;
            }
            else
            {
                p3name.text = pokemon[2].name;
                p3lvl.text = "Lvl " + pokemon[2].level;
                p3hp.text = pokemon[2].health + "/" + pokemon[2].currHealth;

                Color temp = p3image.color;
                temp.a = 255;
                p3image.color = temp;
                p3image.sprite = getImage(pokemon[2].name);
            }


            if (pokemon[3].name.Equals(""))
            {
                p4name.text = "";
                p4lvl.text = "";
                p4hp.text = "";

                Color temp = p4image.color;
                temp.a = 0;
                p4image.color = temp;
            }
            else
            {
                p4name.text = pokemon[3].name;
                p4lvl.text = "Lvl " + pokemon[3].level;
                p4hp.text = pokemon[3].health + "/" + pokemon[3].currHealth;

                Color temp = p4image.color;
                temp.a = 255;
                p4image.color = temp;
                p4image.sprite = getImage(pokemon[3].name);
            }


            if (pokemon[4].name.Equals(""))
            {
                p5name.text = "";
                p5lvl.text = "";
                p5hp.text = "";

                Color temp = p5image.color;
                temp.a = 0;
                p5image.color = temp;
            }
            else
            {
                p5name.text = pokemon[4].name;
                p5lvl.text = "Lvl " + pokemon[4].level;
                p5hp.text = pokemon[4].health + "/" + pokemon[4].currHealth;

                Color temp = p5image.color;
                temp.a = 255;
                p5image.color = temp;
                p5image.sprite = getImage(pokemon[4].name);
            }


            if (pokemon[5].name.Equals(""))
            {
                p6name.text = "";
                p6lvl.text = "";
                p6hp.text = "";

                Color temp = p6image.color;
                temp.a = 0;
                p6image.color = temp;
            }
            else
            {
                p6name.text = pokemon[5].name;
                p6lvl.text = "Lvl " + pokemon[5].level;
                p6hp.text = pokemon[5].health + "/" + pokemon[5].currHealth;

                Color temp = p6image.color;
                temp.a = 255;
                p6image.color = temp;
                p6image.sprite = getImage(pokemon[5].name);
            }
        }
    }

    public Sprite getImage(string name)
    {
        if (name.Equals("Treecko"))
        {
            return tree;
        }
        else if (name.Equals("Grovyle"))
        {
            return grov;
        }
        else if (name.Equals("Sceptile"))
        {
            return scep;
        }
        else if (name.Equals("Torchic"))
        {
            return torc;
        }
        else if (name.Equals("Combusken"))
        {
            return comb;
        }
        else if (name.Equals("Blaziken"))
        {
            return blaz;
        }
        else if (name.Equals("Mudkip"))
        {
            return mudk;
        }
        else if (name.Equals("Marshtomp"))
        {
            return mars;
        }
        else if (name.Equals("Swampert"))
        {
            return swam;
        }
        else if (name.Equals("Poochyena"))
        {
            return pooc;
        }
        else if (name.Equals("Mightyena"))
        {
            return migh;
        }
        else if (name.Equals("Zigzagoon"))
        {
            return zigz;
        }
        else if (name.Equals("Linoone"))
        {
            return lino;
        }
        else if (name.Equals("Kyogre"))
        {
            return kyog;
        }
        else if (name.Equals("Groudon"))
        {
            return grou;
        }
        else if (name.Equals("Rayquaza"))
        {
            return rayq;
        }
        else
        {
            return other;
        }
    }
}

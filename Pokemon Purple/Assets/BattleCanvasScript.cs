using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleCanvasScript : MonoBehaviour
{
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
    public Sprite ralt;
    public Sprite kirl;
    public Sprite gard;
    public Sprite aron;
    public Sprite lair;
    public Sprite aggr;
    public Sprite lota;
    public Sprite lomb;
    public Sprite ludi;
    public Sprite trap;
    public Sprite vibr;
    public Sprite flyg;
    public Sprite bago;
    public Sprite shel;
    public Sprite sala;
    public Sprite kyog;
    public Sprite grou;
    public Sprite rayq;
    public Sprite other;

    public Image enemyImage;
    public Image allyImage;

    public GameObject pokemon;
    public GameObject bag;
    public GameObject battle;

    public Text fightButtonText;
    public Text bagButtonText;
    public Text runButtonText;
    public Text pokemonButtonText;

    public GameObject battleCanvas;
    public GameObject canvasManager;
    private CanvasManager cm;

    public TextMeshProUGUI allyLevel;
    public TextMeshProUGUI enemyLevel;

    public TextMeshProUGUI allyNameText;
    public TextMeshProUGUI enemyNameText;

    public TextMeshProUGUI allyCurrHealth;
    public TextMeshProUGUI allyMaxHealth;

    public TextMeshProUGUI enemyHealth;

    public Trainer t;

    private BattleControl bc;
    private bool caught;
    private Pokemon enemy;
    private Pokemon ally;
    private string enemyName;
       
    // Start is called before the first frame update
    void Start()
    {
        cm = canvasManager.GetComponent<CanvasManager>();
    }

    // Update is called once per frame
    void Update()
    {
            if ( t.pokemon[0] != null )
            {
                enemyNameText.text = enemy.name;
                ally = t.pokemon[0];

                allyNameText.text = ally.name;
                enemyNameText.text = enemy.name;
                allyLevel.text = ally.level + "";
                enemyLevel.text = enemy.level + "";
                allyCurrHealth.text = ally.currHealth + "";
                allyMaxHealth.text = ally.health + "";
                enemyHealth.text = enemy.currHealth + "";

                allyImage.sprite = getImage(ally.name);
                enemyImage.sprite = getImage(enemy.name);
            }

        if ( Input.GetKeyDown(KeyCode.Escape) )
        {
            fightButtonText.text = "FIGHT";
            runButtonText.text = "RUN";
            bagButtonText.text = "BAG";
            pokemonButtonText.text = "POKEMON";
        }
    }
    public void setEnemy(Pokemon enemy)
    {
        this.enemy = enemy;
    }
    public void catchPokemon()
    {
        if (fightButtonText.text.Equals("FIGHT"))
        {
            fightButtonText.text = ally.moveOne;
            runButtonText.text = ally.moveTwo;
            bagButtonText.text = ally.moveThree;
            pokemonButtonText.text = ally.moveFour;
        }
        else
        {
            bc.applyMove(ally.moveOne);
        }
    }

    public void exitBattle()
    {
        if (runButtonText.text.Equals("RUN"))
        {
            battle.SetActive(false);
            pokemon.SetActive(false);
            bag.SetActive(false);
            cm.inBattle = false;
            FindObjectOfType<Movement>().setStasis(false);
        }
        else
        {
            bc.applyMove(ally.moveTwo);
        }

    }

    public void bagBattle()
    {
        if (bagButtonText.text.Equals("BAG"))
        {
            bag.SetActive(true);
        }
        else
        {
            bc.applyMove(ally.moveThree);
        }
    }
    public void pokemonBattle()
    {
        if (pokemonButtonText.text.Equals("POKEMON"))
        {
            pokemon.SetActive(true);
        }
        else
        {
            bc.applyMove(ally.moveFour);
        }
    }

    public void startBattle(Pokemon poke)
    {
        bc = new BattleControl(poke, t);
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
        else if (name.Equals("Raltz"))
        {
            return ralt;
        }
        else if (name.Equals("Kirlia"))
        {
            return kirl;
        }
        else if (name.Equals("Gardevoir"))
        {
            return gard;
        }
        else if (name.Equals("Aron"))
        {
            return aron;
        }
        else if (name.Equals("Lairon"))
        {
            return lair;
        }
        else if (name.Equals("Aggron"))
        {
            return aggr;
        }
        else if (name.Equals("Lotad"))
        {
            return lota;
        }
        else if (name.Equals("Lombre"))
        {
            return lomb;
        }
        else if (name.Equals("Ludicolo"))
        {
            return ludi;
        }
        else if (name.Equals("Trapinch"))
        {
            return trap;
        }
        else if (name.Equals("Vibrava"))
        {
            return vibr;
        }
        else if (name.Equals("Flygon"))
        {
            return flyg;
        }
        else if (name.Equals("Bagon"))
        {
            return bago;
        }
        else if (name.Equals("Shelgon"))
        {
            return shel;
        }
        else if (name.Equals("Salamance"))
        {
            return sala;
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

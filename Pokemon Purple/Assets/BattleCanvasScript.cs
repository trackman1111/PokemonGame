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
    public Sprite kyog;
    public Sprite grou;
    public Sprite rayq;
    public Sprite other;

    public Image enemyImage;
    public Image allyImage;

    public Button fightButton;
    public Button bagButton;
    public Button runButton;
    public Button pokemonButton;

    public GameObject battleCanvas;
    public GameObject canvasManager;
    private CanvasManager cm;

    public TextMeshProUGUI allyLevel;
    public TextMeshProUGUI enemyLevel;

    public TextMeshProUGUI allyNameText;
    public TextMeshProUGUI enemyNameText;

    public TextMeshProUGUI allyCurrHealth;
    public TextMeshProUGUI allyMaxHealth;

    public Trainer t;

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

                allyImage.sprite = getImage(ally.name);
                enemyImage.sprite = getImage(enemy.name);
            }
    }
    public void setEnemy(Pokemon enemy)
    {
        this.enemy = enemy;
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

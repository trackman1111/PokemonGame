using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BagTextScript : MonoBehaviour
{
    public TextMeshProUGUI itemList;
    public TextMeshProUGUI desc;
    public TextMeshProUGUI currItem;
    public TextMeshProUGUI title;
    public Trainer trainer;
    public GameObject bagPanel;
    public Image picture;

    public Sprite pokeball;
    public Sprite greatball;
    public Sprite ultraball;
    public Sprite masterball;
    public Sprite map;
    public Sprite potion;
    public Sprite bike;
    public Sprite revive;
    public Sprite superPotion;
    public Sprite hyperPotion;
    public Sprite maxPotion;

    public GameObject bagCanvas;
    public GameObject battleCanvas;
    public GameObject pokemonCanvas;

    public BattleCanvasScript bcScript;
    public PokemonCanvasScript pcScript;

    int cursor;

    ArrayList bag;
    string[,] pokemon;


    // Start is called before the first frame update
    void Start()
    {
        //  bag = GlobalControl.Instance.bag;
        cursor = 0;
        picture.GetComponent<Image>();
        bcScript = battleCanvas.GetComponent<BattleCanvasScript>();
        pcScript = pokemonCanvas.GetComponent<PokemonCanvasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( bagPanel.activeSelf )
        { 
            bag = trainer.bag;
            title.text = "Items";

            Dictionary<string, int> items =  new Dictionary<string, int>();
            for (int i = 0; i < bag.Count; i++)
            {
                if (items.ContainsKey(bag[i] + ""))
                {
                    items[bag[i] + ""] += 1;
                }
                else
                {
                    items.Add(bag[i] + "", 1);
                }
            }

            string ans = "";
            List<string> keys = new List<string>(items.Keys);

            for (int i = 0; i < items.Count; i++)
            {
                if (keys[i].Equals("Great Ball"))
                {
                    if (i == cursor)
                    {
                        ans += "->" + keys[i] + " \t\tX" + items[keys[i]] + "\n"; ;
                    }
                    else
                    {
                        ans += "   " + keys[i] + " \t\t\tX" + items[keys[i]] + "\n";
                    }
                }
                else if (keys[i].Equals("Max Potion"))
                {
                    if (i == cursor)
                    {
                        ans += "->" + keys[i] + " \t\tX" + items[keys[i]] + "\n"; ;
                    }
                    else
                    {
                        ans += "   " + keys[i] + " \t\tX" + items[keys[i]] + "\n";
                    }
                }
                else if (keys[i].Length <= 10 )
                {
                    if (i == cursor)
                    {
                        ans += "->" + keys[i] + " \t\t\tX" + items[keys[i]] + "\n"; ;
                    }
                    else
                    {
                        ans += "   " + keys[i] + " \t\t\tX" + items[keys[i]] + "\n";
                    }
                }
                else
                {
                    if (i == cursor)
                    {
                        ans += "->" + keys[i] + " \t\tX" + items[keys[i]] + "\n";
                    }
                    else
                    {
                        ans += "   " + keys[i] + " \t\tX" + items[keys[i]] + "\n";
                    }
                }
            }

            itemList.text = ans;
            desc.text = trainer.getDescription(keys[cursor]);
            currItem.text = keys[cursor];
            

            // setting picture

            if ( keys[cursor].Equals("Pokeball") )
            {
                picture.sprite = pokeball;
            }
            else if (keys[cursor].Equals("Great Ball"))
            {
                picture.sprite = greatball;
            }
            else if (keys[cursor].Equals("Ultra Ball"))
            {
                picture.sprite = ultraball;
            }
            else if (keys[cursor].Equals("Master Ball"))
            {
                picture.sprite = masterball;
            }
            else if (keys[cursor].Equals("Map"))
            {
                picture.sprite = map;
            }
            else if (keys[cursor].Equals("Bike"))
            {
                picture.sprite = bike;
            }
            else if (keys[cursor].Equals("Potion"))
            {
                picture.sprite = potion;
            }
            else if (keys[cursor].Equals("Super Potion"))
            {
                picture.sprite = superPotion;
            }
            else if (keys[cursor].Equals("Hyper Potion"))
            {
                picture.sprite = superPotion;
            }
            else if (keys[cursor].Equals("Max Potion"))
            {
                picture.sprite = maxPotion;
            }
            else if (keys[cursor].Equals("Revive"))
            {
                picture.sprite = revive;
            }




            if (Input.GetKeyDown(KeyCode.DownArrow) && cursor < items.Count - 1)
            {
                cursor++;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && cursor > 0)
            {
                cursor--;
            }

            if ( Input.GetKeyDown(KeyCode.RightShift) && cursor >= 0 )
            {
                useItem( keys[cursor] );
            }
        }
    }

    void useItem( string item ) 
    {
        if (item.Equals("Pokeball"))
        {
            if ( battleCanvas.activeSelf )
            {
                useBall("Pokeball");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Great Ball"))
        {
            if (battleCanvas.activeSelf)
            {
                useBall("Great Ball");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Ultra Ball"))
        {
            if (battleCanvas.activeSelf)
            {
                useBall("Ultra Ball");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Master Ball"))
        {
            if (battleCanvas.activeSelf)
            {
                useBall("Master Ball");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Map"))
        {
            if (!battleCanvas.activeSelf)
            {
                bagCanvas.SetActive(false);
                print("Map Opened");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Bike"))
        {
            if (!battleCanvas.activeSelf )
            {
                bagCanvas.SetActive(false);
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Potion"))
        {
            if (pokemonCanvas.activeSelf || battleCanvas.activeSelf)
            {
                usePotion("Potion");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Super Potion"))
        {
            if (pokemonCanvas.activeSelf || battleCanvas.activeSelf)
            {
                usePotion("Super Potion");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Hyper Potion"))
        {
            if (pokemonCanvas.activeSelf || battleCanvas.activeSelf)
            {
                usePotion("Hyper Potion");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Max Potion"))
        {
            if (pokemonCanvas.activeSelf || battleCanvas.activeSelf)
            {
                usePotion("Max Potion");
            }
            else
            {
                print("STOOPID, IM NOT GONNA LET YOU GET THE CHANCE");
            }
        }
        else if (item.Equals("Revive"))
        {
            useRevive(item);
        }

    }

    public void useRevive(string item)
    {
        bagCanvas.SetActive(false);
        pokemonCanvas.SetActive(true);
        pcScript.revived = false;
        pcScript.description.text = "Select a pokemon to revive";
    }

    public void usePotion(string type)
    {
        if (trainer.pokemon[0].currHealth != trainer.pokemon[0].health)
        {
            bcScript.usePotion(type);
            bagCanvas.SetActive(false);
            bag.Remove(type);
        }
        else
        {
            print("Your Pokemon is already at full health!");
        }
    }

    public void useBall(string type)
    {

        if (bcScript.isTrainer)
        {
            print("You cannot catch another trainer's pokemon!");
        }
        else
        {
            print("You threw a " + type + "!");
            bagCanvas.SetActive(false);
            bag.Remove(type);

            int randoNum = 100;
            System.Random rnd = new System.Random();


            if (type.Equals("Pokeball"))
            {
                randoNum = rnd.Next(1, 100);

                if (randoNum <= 50)
                {
                    bcScript.usePokeball(type, true);
                }
                else
                {
                    bcScript.usePokeball(type, false);
                }
            }
            else if (type.Equals("Great Ball"))
            {
                randoNum = rnd.Next(1, 100);

                if (randoNum <= 75)
                {
                    bcScript.usePokeball(type, true);
                }
                else
                {
                    bcScript.usePokeball(type, false);
                }
            }
            else if (type.Equals("Ultra Ball"))
            {
                randoNum = rnd.Next(1, 100);

                if (randoNum <= 90)
                {
                    bcScript.usePokeball(type, true);
                }
                else
                {
                    bcScript.usePokeball(type, false);
                }
            }
            else
            {
                bcScript.usePokeball("Master Ball", true);
            }
        }
    }

    void SavePlayer()
    {
        //GlobalControl.Instance.bag = bag;
    }
}

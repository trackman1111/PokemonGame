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

    int cursor;

    ArrayList bag;
    string[,] pokemon;

    // Start is called before the first frame update
    void Start()
    {
        //  bag = GlobalControl.Instance.bag;
        cursor = 0;

        picture.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( bagPanel.activeSelf )
        { 
            bag = trainer.bag;
            title.text = "Items";


            Dictionary<string, int> items = new Dictionary<string, int>();

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
        }
    }

    void SavePlayer()
    {
        //GlobalControl.Instance.bag = bag;
    }
}

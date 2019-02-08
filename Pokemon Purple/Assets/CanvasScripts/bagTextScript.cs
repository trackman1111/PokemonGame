using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bagTextScript : MonoBehaviour
{
    public TextMeshProUGUI itemList;
    public TextMeshProUGUI desc;
    public TextMeshProUGUI currItem;
    public Trainer trainer;

    int cursor;

    ArrayList bag;

    // Start is called before the first frame update
    void Start()
    {
        //  bag = GlobalControl.Instance.bag;
        cursor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bag = trainer.bag;

            Dictionary<string, int> items = new Dictionary<string, int>();

            for (int i = 0; i < bag.Count; i++)
            {
                if ( items.ContainsKey(bag[i] + ""))
                {
                    items[bag[i] + ""] += 1;
                }
                else
                {
                    items.Add(bag[i]+"", 1);
                }
            }

            string ans = "";
            List<string> keys = new List<string>(items.Keys);

            for ( int i = 0; i < items.Count; i++ )
            {
                if (keys[i].Length <= 4)
                {
                    ans += keys[i] + " \t\t\tX" + items[keys[i]] + "\n";
                }
                else
                {
                    ans += keys[i] + " \t \tX" + items[keys[i]] + "\n";
            }
        }

        itemList.text = ans;
        desc.text = trainer.getDescription(keys[cursor]);
        currItem.text = keys[cursor];

        if (Input.GetKeyDown(KeyCode.DownArrow) && cursor < items.Count - 1)
        {
            cursor++;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && cursor > 0)
        {
            cursor--;
        }

    }

    void SavePlayer()
    {
        //GlobalControl.Instance.bag = bag;
    }
}

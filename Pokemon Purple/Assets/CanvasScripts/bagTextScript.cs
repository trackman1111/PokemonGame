using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bagTextScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Trainer trainer;

    
    bool isOpen = true;

    // Start is called before the first frame update
    void Start()
    {
        //  bag = GlobalControl.Instance.bag;
    }

    // Update is called once per frame
    void Update()
    {
        ArrayList bag = trainer.bag;
            Dictionary<string, int> items = new Dictionary<string, int>();

            for (int i = 0; i < bag.Count - 1; i++)
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

            text.text = ans;

            isOpen = false; ;
    }

    void SavePlayer()
    {
        //GlobalControl.Instance.bag = bag;
    }
}

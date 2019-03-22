using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trainer : MonoBehaviour
{
    // core 2d array for most of my methods. has 6 slots, 1 for each pokemon
    public Pokemon[] pokemon = new Pokemon[6];
    public ArrayList bag;
    private Movement movement;

    public int cash;

    // Start is called before the first frame update
    void Start()
    {
        movement = gameObject.GetComponent<Movement>();
        // adding all default items to bag array
        bag = new ArrayList();


        bag.Add("Pokeball");
        bag.Add("Ultra Ball");
        bag.Add("Great Ball");
        bag.Add("Potion");
        bag.Add("Super Potion");
        bag.Add("Hyper Potion");
        bag.Add("Max Potion");
        bag.Add("Potion");
        bag.Add("Revive");
        bag.Add("Master Ball");
        bag.Add("Master Ball");
        bag.Add("Master Ball");
        bag.Add("Master Ball");
        bag.Add("Pokeball");
        bag.Add("Bike");
        bag.Add("Map");
    }

    // Update is called once per frame
    void Update()
    {
        // BUTTON CONFIGURATIONS -----------------------------------------------------------------------------------------------------------------------


        // Press P to add Blaziken to your bag 


        if (Input.GetKeyDown(KeyCode.O))
        {
            addPokemon(new Pokemon("Zigzagoon"));
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            addPokemon(new Pokemon("Blaziken"));
        }

        // Press Q to add Potion to your bag 

        if (Input.GetKeyDown(KeyCode.Q))
        {
            addItem("Master Ball");
        }

    }


    public void addPokemon(Pokemon poke)
    {
        bool added = false;
        for (int i = 0; i < 6; i++)
        {
            if (pokemon[i] == null && added == false)
            {
                pokemon[i] = poke;
                added = true;
                print("You have added " + poke.name + " to your Bag!");
            }
        }
    }
    public void addItem(string name)
    {
        bag.Add(name);
    }

    // used for bag. you give it an item name and it returns a description.

    public string getDescription(string s)
    {
        if ( s.Equals("Pokeball") )
        {
            return "A pokeball allows a trainer to catch a wild pokemon with a normal catch rate";
        }
        else if (s.Equals("Great Ball"))
        {
            return "A Great Ball allows a trainer to catch a wild pokemon with a better catch rate";
        }
        else if (s.Equals("Ultra Ball"))
        {
            return "An Ultra Ball allows a trainer to catch a wild pokemon with an amazing catch rate";
        }
        else if (s.Equals("Master Ball"))
        {
            return "A Master Ball allows a trainer to catch a wild pokemon with a 100% catch rate";
        }
        else if (s.Equals("Map"))
        {
            return "A map allows a trainer to see the whole world";
        }
        else if(s.Equals("Potion"))
        {
            return "A potion allows a trainer to heal a pokemon for 20hp";
        }
        else if (s.Equals("Super Potion"))
        {
            return "A potion allows a trainer to heal a pokemon for 50hp";
        }
        else if (s.Equals("Hyper Potion"))
        {
            return "A potion allows a trainer to heal a pokemon for 100hp";
        }
        else if (s.Equals("Max Potion"))
        {
            return "A potion allows a trainer to heal a pokemon to max heal";
        }
        else if (s.Equals("Revive"))
        {
            return "A revive allows a trainer to bring a pokemon with 0 hp back to half health";
        }
        else if (s.Equals("Bike"))
        {
            return "A bike allows a trainer to move at twice the speed";
        }
        else
        {
            return "Invalid item name";
        }
    }

    internal void reset()
    {
        movement.setPostition(new Vector3(-5.5f, 6,-1));
        fullHealth();
        print("You were sent back to pokecenter/all your pokemon were healed");
    }


    // this method written by the goat coder is supposed to be when you press
    // a button a pop up screen comes up and acts like a poke mart in pokemon!

    void shop()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            // I need to display a screen of the object they are selling
            if (cash > 10) // where the 10 is there should be a price which is pulled from the picture
            {
                cash = cash - 10;
                // need to add the object to the bag
            }
        }
    }
    public void fullHealth()
    {
        for (int i = 0; i < pokemon.Length; i++)
        {
            if (pokemon[i] == null)
            {
                return;
            }
            pokemon[i].heal();
        }
    }

}
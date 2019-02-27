using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trainer : MonoBehaviour
{

    // this class will depend on the pokemon class having the fields type and name, both are strings.

    // core 2d array for most of my methods
    public Pokemon[] pokemon = new Pokemon[6];

    public ArrayList bag;
    private int cash;

    // Start is called before the first frame update
    void Start()
    {
        // adding all default items to bag array
        bag = new ArrayList();

        bag.Add("Pokeball");
        bag.Add("Pokeball");
        bag.Add("Ultra Ball");
        bag.Add("Great Ball");
        bag.Add("Potion");
        bag.Add("Revive");
        bag.Add("Master Ball");
        bag.Add("Bike");

        string temp = PlayerPrefs.GetString("Starter");
        pokemon[0] = new Pokemon("Treecko");


        pokemon[1] = new Pokemon("");
        pokemon[2] = new Pokemon("");
        pokemon[3] = new Pokemon("");
        pokemon[4] = new Pokemon("");
        pokemon[5] = new Pokemon("");
    }

    // Update is called once per frame
    void Update()
    {
        int xVal = (int)transform.position.x;
        int yVal = (int)transform.position.y;

        // if ( worldMap[xval][yval].isBush )  returns boolean if this slot in the 2d world array is a bush
        {
            int chanceOfSpawn = Random.Range(1, 100);    // 10 percent chance that if you are on a bush, a random pokemon will spawn
            if (chanceOfSpawn >= 90)
            {
                encounter();                             // calls encounter method, with eventually use another stage and be the baseline for duels.
            }
        }


        // BUTTON CONFIGURATIONS -----------------------------------------------------------------------------------------------------------------------

        if (Input.GetKeyDown(KeyCode.P))
        {
            bool added = false;
            for ( int i = 0; i < 6; i++ )
            {
                if ( pokemon[i].name.Equals("") && added == false )
                {
                    pokemon[i] = new Pokemon("Blaziken");
                    added = true;
                }
            }
        }

        if ( Input.GetKeyDown(KeyCode.Q) )
        {
            bag.Add("Potion");
        }
    }

    // this method will eventually take in a Pokemon()

    void addPokemon( Pokemon poke )
    {
        if ( pokemon[5].Equals("") ) 
        {
            System.Boolean addedPoke = false;
            int slot = 0;
            while ( !addedPoke && slot < 6)
            {
                if ( pokemon[slot].Equals("") )
                {
                    pokemon[slot] = poke;
                    addedPoke = true;
                }
                slot++;
            }

            print(poke + " was added in slot " + slot);
        }
        else
        {
            print("You already have 6 pokemon!");
        }
    }

    // prints all of the Trainers Pokemons name to console
    void printPokemon()
    {
        if (pokemon[0].name.Equals(""))
        {
            print("You have no pokemon");
        }
        for (int i = 0; i < 6; i++)
        {
            string currPoke = pokemon[i].name;

            if (!currPoke.Equals(""))
            {
                print("Slot " + (i + 1) + " is " + currPoke);
            }
        }
    }

    // this method clear the developer console... looks clean for user

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



    // this method occurs 10% of the time when a trainer is in a bush
    void encounter()
    {

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

}
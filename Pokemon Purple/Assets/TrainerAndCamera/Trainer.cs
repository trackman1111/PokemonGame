using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trainer : MonoBehaviour
{
    // core 2d array for most of my methods. has 6 slots, 1 for each pokemon
    public Pokemon[] pokemon = new Pokemon[6];
    public ArrayList bag;
    private GameObject gameObj;

    public int cash;

    int pok1;
    int pok2;

    private bool pressed;
    private bool firstPicked;
    private bool secondPicked;
    // Start is called before the first frame update
    void Start()
    {
        gameObj = GetComponent<GameObject>();
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

        pressed = false;
        firstPicked = false;

        pok1 = 0;
        pok2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // BUTTON CONFIGURATIONS -----------------------------------------------------------------------------------------------------------------------


        // Press P to add Blaziken to your bag 

        if (Input.GetKeyDown(KeyCode.P))
        {
            addPokemon("Blaziken");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            addPokemon("Swampert");
        }


        // Press Q to add Potion to your bag 

        if ( Input.GetKeyDown(KeyCode.Q) )
        {
            addItem("Master Ball");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            pressed = true;
            print("Which two pokemon would you like to swap? (A-H)  (Z-N)");
        }

        if ( pressed )
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                pok1 = 1;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                pok1 = 2;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                pok1 = 3;
            }
            else if (Input.GetKeyDown(KeyCode.F))
            {
                pok1 = 4;
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                pok1 = 5;
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                pok1 = 6;
            }

            if ( pok1 != 0 && pokemon[pok1] != null )
            {
                print(pokemon[pok1 - 1].name + " was selected");
                pressed = false;
                firstPicked = true;
            }
            else if ( pok1 != 0 )
            {
                print("Bad Input");
                pok1 = 0;
                pok2 = 0;
                pressed = false;
            }
        }

        if (firstPicked)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                pok2 = 1;
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                pok2 = 2;
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                pok2 = 3;
            }
            else if (Input.GetKeyDown(KeyCode.V))
            {
                pok2 = 4;
            }
            else if (Input.GetKeyDown(KeyCode.B))
            {
                pok2 = 5;
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                pok2 = 6;
            }

            if (pok2 != 0 && pokemon[pok1] != null)
            {
                print(pokemon[pok2 - 1].name + " was selected");
                firstPicked = false;
            }
            else if (pok2 != 0)
            {
                print("Bad Input");
                pok1 = 0;
                pok2 = 0;

            }

            if (pok1 != 0 && pok2 != 0)
            {
                swapPokemon(pok1 - 1, pok2 - 1);
                pok1 = 0;
                pok2 = 0;
            }
        }
    }


    public void addPokemon(string name)
    {
        bool added = false;
        for (int i = 0; i < 6; i++)
        {
            if (pokemon[i] == null && added == false)
            {
                pokemon[i] = new Pokemon(name);
                added = true;
                print("You have added " + name+ " to your Bag!");
            }
        }
    }
    public void addItem(string name)
    {
        bag.Add(name);
    }


    public void swapPokemon(int movedPoke, int desiredSlot)
    {
        // print("What Pokemon would you like to move? (1-6)");
        // int movedPoke = int.Parse(Input.compositionString);

        //  print("What slot would you like to put this pokemon?  (1-6)");
        //  int desiredSlot = int.Parse(Input.compositionString);

        if (pokemon[movedPoke] != null || pokemon[desiredSlot] != null)
        {
            Pokemon temp = pokemon[desiredSlot];
            pokemon[desiredSlot] = pokemon[movedPoke];
            pokemon[movedPoke] = temp;

            print(pokemon[desiredSlot].name + " was swapped with " + pokemon[movedPoke].name);
        }
        else
        {
            print("Bad Input");
        }
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
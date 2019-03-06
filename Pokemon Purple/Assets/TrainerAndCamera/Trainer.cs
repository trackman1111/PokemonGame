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
            if (pokemon[1] != null)
            {
                pressed = true;
                print("Which two pokemon would you like to swap?");

                print("Use 1-6 to highlight a pokemon, then press Right Shift to confirm selection");
            }
            else
            {
                print( "Not enough Pokemon to swap." );
            }
        }

        if ( pressed )
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {            
                pok1 = 1;
                print(pokemon[pok1 - 1].name + " is highlighted");
            }
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                pok1 = 2;
                print(pokemon[pok1 - 1].name + " is highlighted");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if ( pokemon[2] != null )
                {
                    pok1 = 3;
                    print(pokemon[pok1 - 1].name + " is highlighted");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (pokemon[3] != null)
                {
                    pok1 = 4;
                    print(pokemon[pok1 - 1].name + " is highlighted");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                if (pokemon[4] != null)
                {
                    pok1 = 5;
                    print(pokemon[pok1 - 1].name + " is highlighted");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                if (pokemon[5] != null)
                {
                    pok1 = 6;
                    print(pokemon[pok1 - 1].name + " is highlighted");
                }
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {

                if ( pok1 != 0 && pokemon[pok1 - 1] != null )
                {
                    print(pokemon[pok1 - 1].name + " was selected. Select the pokemon you would like to swap " + pokemon[pok1 - 1].name + " with");
                    firstPicked = true;
                    pok2 = 0;
                    pressed = false;
                }
            }
        }

        if(firstPicked)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                pok2 = 1;
                print(pokemon[pok2 - 1].name + " is highlighted");
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                pok2 = 2;
                print(pokemon[pok2 - 1].name + " is highlighted");
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (pokemon[2] != null)
                {
                    pok2 = 3;
                    print(pokemon[pok2 - 1].name + " is highlighted");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (pokemon[3] != null)
                {
                    pok2 = 4;
                    print(pokemon[pok2 - 1].name + " is highlighted");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                if (pokemon[4] != null)
                {
                    pok2 = 5;
                    print(pokemon[pok2 - 1].name + " is highlighted");
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                if (pokemon[5] != null)
                {
                    pok2 = 6;
                    print(pokemon[pok2 - 1].name + " is highlighted");
                }
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                if (pok2 != 0 && pokemon[pok2 - 1] != null)
                {
                    firstPicked = false;
                    print(pokemon[pok2 - 1].name + " was selected");

                    if ( pok1 != pok2 )
                    { 
                        swapPokemon(pok1 - 1, pok2 - 1);
                    }
                    else
                    {
                        print("Select two different pokemon to swap.");
                    }
                    pok1 = 0;
                    pok2 = 0;
                }
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
        Pokemon temp = pokemon[desiredSlot];
        pokemon[desiredSlot] = pokemon[movedPoke];
        pokemon[movedPoke] = temp;

        print(pokemon[desiredSlot].name + " was swapped with " + pokemon[movedPoke].name);
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
    public void fullHealth()
    {
        for(int i = 0; i < pokemon.Length; i++ )
        {
            if(pokemon[i] == null)
            {
                return;
            }
            pokemon[i].heal();
        }
    }

}
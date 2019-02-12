using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trainer : MonoBehaviour
{

    // this class will depend on the pokemon class having the fields type and name, both are strings.

        // core 2d array for most of my methods
    public string[,] pokemon = new string[6, 4]
    {
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""}
    };

    public ArrayList bag;

    // Start is called before the first frame update
    void Start()
    {
        // adding all default items to bag array
        bag = new ArrayList();

        bag.Add("Pokeball");
        bag.Add("Pokeball");
        bag.Add("Ultra Ball");
        bag.Add("Map");
        bag.Add("Bike");

        clearConsole();

        pokemon[0,0] = PlayerPrefs.GetString("Starter");
      // Pokemon starter = new Pokemon( PlayerPrefs.GetString("Starter")));
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
        
        // showing pokemon array
            
        if (Input.GetKeyDown(KeyCode.P))                    //  if 'C' is down, then call printPokemon(), which displays all items in the bag into the Console 
        {
            printPokemon();
        }

        // clearing console for cleanliness

        if (Input.GetKeyDown(KeyCode.C))
        {
            clearConsole();
        }

        // adding pokemon to pokemon array

        if (Input.GetKeyDown(KeyCode.T))                    //  if 'T' is down, then add squirtle to pokemon array
        {
            Pokemon squirtle = new Pokemon();
            addPokemon(squirtle);

            // Pokemon temp = new Pokemon( Squirtle );          repeat this concept for next 5 if statements
            // addPokemon(temp);
        }

        if (Input.GetKeyDown(KeyCode.Y))                    //  if 'Y' is down, then add bulbasaur to pokemon array
        {
            Pokemon bulbasaur = new Pokemon();
            addPokemon(bulbasaur);
        }
        if (Input.GetKeyDown(KeyCode.U))                    //  if 'U' is down, then add charmander to pokemon array
        {
            Pokemon charmander = new Pokemon();
            addPokemon(charmander);
        }
        if (Input.GetKeyDown(KeyCode.I)  )                  //  if 'I' is down, then add sandshrew to pokemon array
        {
            Pokemon sandshrew = new Pokemon();
            addPokemon(sandshrew);
        }

        if (Input.GetKeyDown(KeyCode.O))                    //  if 'O' is down, then add pikachu to pokemon array
        {
            Pokemon pikachu = new Pokemon();
            addPokemon( pikachu );
        }
        if ( Input.GetKeyDown(KeyCode.Q) )
        {
            bag.Add("Potion");
        }
    }

    // this method will eventually take in a Pokemon()

    void addPokemon( Pokemon poke )
    {
        if ( pokemon[5,0].Equals("") ) 
        {
            System.Boolean addedPoke = false;
            int slot = 0;
            while ( !addedPoke && slot < 6)
            {
                if ( pokemon[slot, 0].Equals("") )
                {
                    pokemon[slot, 0] = poke.name;
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
        if (pokemon[0, 0].Equals(""))
        {
            print("You have no pokemon");
        }
        for (int i = 0; i < 6; i++)
        {
            string currPoke = pokemon[i, 0] + "";

            if (!currPoke.Equals(""))
            {
                print("Slot " + (i + 1) + " is " + currPoke + " and has the moves " + pokemon[i, 1] + ", " + pokemon[i, 2] + ", " + pokemon[i, 3]);
            }
        }
    }

    // this method clear the developer console... looks clean for user

    void clearConsole()
    {
        var logEntries = System.Type.GetType("UnityEditor.LogEntries, UnityEditor.dll");
        var clearMethod = logEntries.GetMethod("Clear", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
        clearMethod.Invoke(new object(), null);

        print("Press T to add Squirtle, Y for Bulbasuar, U for Charmander, I for Sandshrew, or O for Pikachu )");
        print("Press B to see your bag, Press P to see your pokemon, and press C to clear the console.");
    }

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

}
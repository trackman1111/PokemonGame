using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : MonoBehaviour
{

    // this class will depend on the pokemon class having the fields type and name, both are strings.
    //added comment
    string[,] pokemon = new string[6, 4]
    {
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""},
        { "", "", "", ""}
    };
    ArrayList bag = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        // adding all default items to bag array
        bag.Add("map");
        bag.Add("pokeball");
        bag.Add("ulra ball");
        bag.Add("master ball");

        clearConsole();
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

        // showing bag array

        if (Input.GetKeyDown(KeyCode.B))                    //  if 'b' is down, then call printBag(), which displays all items in the bag into the Console 
        {
            printBag();
        }
        
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
            addPokemon("Squirtle", "Water");
        }

        if (Input.GetKeyDown(KeyCode.Y))                    //  if 'Y' is down, then add bulbasaur to pokemon array
        {
            addPokemon("Bulbasaur", "Grass");
        }
        if (Input.GetKeyDown(KeyCode.U))                    //  if 'U' is down, then add charmander to pokemon array
        {
            addPokemon("Charmander", "Fire");
        }

        if (Input.GetKeyDown(KeyCode.I)  )                  //  if 'I' is down, then add sandshrew to pokemon array
        {
            addPokemon("Sandshrew", "Ground");
        }

        if (Input.GetKeyDown(KeyCode.O))                    //  if 'O' is down, then add pikachu to pokemon array
        {
            // Pokemon pikachu = new Pokemon();
            addPokemon("Pikachu", "Electric");
        }
    }

    // this method will eventually take in a Pokemon()

    void addPokemon( string poke, string type )
    {
        if ( pokemon[5,0].Equals("") ) 
        {
            System.Boolean addedPoke = false;
            int slot = 0;
            while ( !addedPoke && slot < 6)
            {
                if ( pokemon[slot, 0].Equals("") )
                {
                    pokemon[slot, 0] = poke;
                    makeMoves(type, slot);
                    // pokemon[slot, 0] = poke.name             the pokemon class will eventually have the fields name and type
                    // makeMoves( poke.type , slot );
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


    // this method initializes the moves for your pokemon at the beggining of the game
    void makeMoves( string type, int slot )
    {
        if ( type.Equals("Water") ) {

           pokemon[slot, 1] = "Tackle";
           pokemon[slot, 2] = "Tail Whip";
           pokemon[slot, 3] = "Bubble";
        }
        else if (type.Equals("Fire")){
            pokemon[slot, 1] = "Scratch";
            pokemon[slot, 2] = "Growl";
            pokemon[slot, 3] = "Ember";
        }
        else if (type.Equals("Grass")){
            pokemon[slot, 1] = "Growl";
            pokemon[slot, 2] = "Tackle";
            pokemon[slot, 3] = "Vine Whip";
        }
        else if (type.Equals("Ground")){
            pokemon[slot, 1] = "Defense Curl";
            pokemon[slot, 2] = "Scratch";
            pokemon[slot, 3] = "Sand Attack";
        }
        else if (type.Equals("Electric")){
            pokemon[slot, 1] = "Growl";
            pokemon[slot, 2] = "Tail Whip";
            pokemon[slot, 3] = "Thunder Shock";
        }
    }

    // adds a pokemon of users choice to the pokemon array

    // prints all items in the Trainers bag to the console
    void printBag()
    {
        for (int i = 0; i < bag.Count; i++)
        {
            print(bag[i]);
        }
    }

    // prints all of the Trainers Pokemons name to console
    void printPokemon()
    {
        if ( pokemon[0,0].Equals("") )
        {
            print("You have no pokemon");
        }
        for (int i = 0; i < 6; i++)
        {
            string currPoke = pokemon[i , 0] + "";

            if (!currPoke.Equals(""))
            {
                print("Slot " + (i + 1) + " is " + currPoke +" and has the moves " + pokemon[i,1] + ", " + pokemon[i,2] + ", " + pokemon[i, 3]);
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


    // this method occurs 10% of the time when a trainer is in a bush
    void encounter()
    {

    }
}

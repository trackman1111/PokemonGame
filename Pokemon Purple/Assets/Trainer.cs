using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trainer : MonoBehaviour
{

    // this class will depend on the pokemon class having the fields type and name, both are strings.

    ArrayList pokemon = new ArrayList();
    ArrayList moves = new ArrayList();
    ArrayList bag = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < pokemon.Count; i++)       // .Count is .length() in c#
        {
            // makeMoves( pokemon[i].type );
        }

        print("Press Y to add Squirtle, U for Bulbasuar, I for Charmander, O for Sandshrew, or P for Pikachu )");
        print("Press B to see your bag, Press P to see your pokemon, and press C to clear the console.");

        // adding all default items to bag array
        bag.Add("map");
        bag.Add("pokeball");
        bag.Add("ulra ball");
        bag.Add("master ball");
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

        if (Input.GetKeyDown(KeyCode.C));
        {
            // LOOK UP HOW TO CLEAR CONSOLE

            Debug.ClearDeveloperConsole();
            // clearConsoleMethod.Invoke(new object(), null);
        }

        // adding pokemon to pokemon array

        if (Input.GetKeyDown(KeyCode.T))                    //  if 'T' is down, then add squirtle to pokemon array
        {
            addPokemon("Squirtle");
        }

        if (Input.GetKeyDown(KeyCode.Y))                    //  if 'Y' is down, then add bulbasaur to pokemon array
        {
            addPokemon("Bulbasaur");
        }
        if (Input.GetKeyDown(KeyCode.U))                    //  if 'U' is down, then add charmander to pokemon array
        {
            addPokemon("Charmander");
        }

        if (Input.GetKeyDown(KeyCode.I)  )                  //  if 'I' is down, then add sandshrew to pokemon array
        {
            addPokemon("Sandshrew");
        }

        if (Input.GetKeyDown(KeyCode.O))                    //  if 'O' is down, then add pikachu to pokemon array
        {
            addPokemon("Pikachu");
        }
    }

    void addPokemon( string name )
    {
        if ( pokemon.Count < 6 ) 
        {
            pokemon.Add(name);
            print( name + " was added." );
        }
        else
        {
            print("You already have 6 pokemon!");
        }
    }


    // this method initializes the moves for your pokemon at the beggining of the game
    void makeMoves( string type)
    {
        if ( type.Equals("Water") ) {
            moves.Add("Tackle");
            moves.Add("Tail Whip");
            moves.Add("Bubble");
        }
        else if (type.Equals("Fire")){
            moves.Add("Scratch");
            moves.Add("Growl");
            moves.Add("Ember");
        }
        else if (type.Equals("Grass")){
            moves.Add("Growl");
            moves.Add("Tackle");
            moves.Add("Vine Whip");
        }
        else if (type.Equals("Ground")){
            moves.Add("Defense Curl");
            moves.Add("Scratch");
            moves.Add("Sand Attack");
        }
        else if (type.Equals("Electric")){ 
            moves.Add("Growl");
            moves.Add("Tail Whip");
            moves.Add("Thunder Shock");
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
        for (int i = 0; i < pokemon.Count; i++)
        {
            string currPoke = pokemon[i] + "";
            print( "Slot " + (i + 1) + " is " + currPoke );
        }
    }


    // this method occurs 10% of the time when a trainer is in a bush
    void encounter()
    {

    }
}

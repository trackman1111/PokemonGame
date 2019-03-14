using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Drawing;
using UnityEngine.UI;

public class Pokemon
{
    string type;
    public string name;
    public GameObject trainer;
    private PokemonData pokeData;
    public int health;
    public int currHealth;
    public int defence;
    public int attack;
    public int speed;
    public int level;
    public int exp;
    private int counter = 1;
    public string types;
    public string moveOne;
    public string moveTwo;
    public string moveThree;
    public string moveFour;
    private IDictionary<string, double[]> movesPower;
    //private image image;

    public Pokemon(String name)
    {
        pokeData = new PokemonData();
        this.name = name;
        double[] pokemonArrayStats = pokeData.makePokemon(name);
        this.health = (int)pokemonArrayStats[0];
        this.currHealth = (int)pokemonArrayStats[0];
        currHealth = 5;
        this.attack = (int)pokemonArrayStats[1];
        this.defence = (int)pokemonArrayStats[2];
        this.speed = (int)pokemonArrayStats[3];
        this.level = (int)pokemonArrayStats[4];
        this.exp = (int)pokemonArrayStats[5];
        string types = pokeData.getType(this.name);
        this.types = types;
        string[] temp = pokeData.makeMoves(types, this.level);
        this.moveOne = temp[0];
        this.moveTwo = temp[1];
        this.moveThree = temp[2];
        this.moveFour = temp[3];


    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //pokedex();
    }
    //return a string array and it should have a new parameter int that represents the level
   
   //public void pokedex()
   //{

    //    // Have to display this on the screen when asked
    //    List<string> pokemonNames = new List<string>(this.pokemon.Keys);
    //    if(Input.GetKeyDown(KeyCode.H))
    //    {
    //        for(int i = 0; i < pokemonNames.Count; i++)
    //        {
    //            //print(pokemonNames[i]);
    //        }
    //    }
    //}
    public string[] getMovesFromPokemon()
    {
        return pokeData.makeMoves(this.type, level);
    }
    public void heal()    // this method is used when you walk into a pokeCenter and press yes
    {
        this.currHealth = this.health;
    }

    public void addHealth(int healthAdded) // this is the method that is used when the user uses a potion of some sort
    {
        if(currHealth + healthAdded >= health)
        {
            currHealth = health;
        }
        else
        {
            currHealth = currHealth + healthAdded;
        }
    }

}

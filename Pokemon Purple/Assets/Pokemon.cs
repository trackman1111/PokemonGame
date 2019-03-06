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
    public Sprite tree;
    public Sprite grov;
    public Sprite scep;
    public Sprite torc;
    public Sprite comb;
    public Sprite blaz;
    public Sprite mudk;
    public Sprite mars;
    public Sprite swam;
    public Sprite pooc;
    public Sprite migh;
    public Sprite zigz;
    public Sprite lino;
    public Sprite kyog;
    public Sprite grou;
    public Sprite rayq;
    public Sprite other;
    private PokemonData pokeData;
    public int health;
    public int currHealth;
    public int defence;
    public int attack;
    public int speed;
    public int level;
    public int exp;
    private int counter = 1;
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
        //this.currHealth = (int)pokemonArrayStats[0];
        this.currHealth = 5;
        this.attack = (int)pokemonArrayStats[1];
        this.defence = (int)pokemonArrayStats[2];
        this.speed = (int)pokemonArrayStats[3];
        this.level = (int)pokemonArrayStats[4];
        this.exp = (int)pokemonArrayStats[5];
        string[] temp = pokeData.makeMoves(this.name, this.level);
        this.moveOne = temp[0];
        this.moveTwo = temp[1];
        this.moveThree = temp[2];           // This code doesn't really work because i am sending it a name not a type
        this.moveFour = temp[3];            // Need to fix this with prob a dictionary <pokemon, string>


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
   public Sprite getImage()
    {
        if(name.Equals("Treecko"))
        {
            return tree;
        }
        else if(name.Equals("Grovyle"))
        {
            return grov;
        }
        else if(name.Equals("Sceptile"))
        {
            return scep;
        }
        else if(name.Equals("Torchic"))
        {
            return torc;
        }
        else if(name.Equals("Combusken"))
        {
            return comb;
        }
        else if (name.Equals("Blaziken"))
        {
            return blaz;
        }
        else if (name.Equals("Mudkip"))
        {
            return mudk;
        }
        else if (name.Equals("Marshtomp"))
        {
            return mars;
        }
        else if (name.Equals("Swampert"))
        {
            return swam;
        }
        else if (name.Equals("Poochyena"))
        {
            return pooc;
        }
        else if (name.Equals("Mightyena"))
        {
            return migh;
        }
        else if (name.Equals("Zigzagoon"))
        {
            return zigz;
        }
        else if (name.Equals("Linoone"))
        {
            return lino;
        }
        else if (name.Equals("Kyogre"))
        {
            return kyog;
        }
        else if (name.Equals("Groudon"))
        {
            return grou;
        }
        else if (name.Equals("Rayquaza"))
        {
            return rayq;
        }
        else
        {
            return other;
        }
    }
    //public string[] getMovesForPokemon(string name)
    //{

    //}
    public void heal()
    {
        this.currHealth = this.health;
    }

}

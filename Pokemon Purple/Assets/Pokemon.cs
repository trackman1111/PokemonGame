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
   
    public void movePower()
    {
        movesPower = new Dictionary<string, double[]>();
        // key is the move and dictionary [damage, defence]

        // start of water type moves
        double[] tack = {30.0, 40.0 };
        movesPower.Add("Tackle", tack);

        double[] wate = { 45.0, 55.0 };
        movesPower.Add("Water Gun", wate);

        double[] defe = { 45.0, 55.0 };
        movesPower.Add("Defence Curl", defe);

        double[] bubb = { 45.0, 55.0 };
        movesPower.Add("Bubble", bubb);

        double[] surf = { 45.0, 55.0 };
        movesPower.Add("Surf", surf);

        double[] hydr = { 45.0, 55.0 };
        movesPower.Add("Hydro Pump", hydr);

        // start of fire type moves
        double[] scra = { 45.0, 55.0 };
        movesPower.Add("Scratch", scra);

        double[] embe = { 45.0, 55.0 };
        movesPower.Add("Ember", embe);

        double[] grow = { 45.0, 55.0 };
        movesPower.Add("Growl", grow);

        double[] quic = { 45.0, 55.0 };
        movesPower.Add("Quick Attack", hydr);

        double[] flam = { 45.0, 55.0 };
        movesPower.Add("Flamethrower", flam);

        double[] fire = { 45.0, 55.0 };
        movesPower.Add("Fire Blast", hydr);

        // start of grass type moves
        //"Peck", "Leech Seed", "Growl", "Razor Leaf" gigadrain solar beam
        double[] peck = { 45.0, 55.0 };

        double[] leec = { 45.0, 55.0 };

        double[] gro = { 45.0, 55.0 };

        double[] razo = { 45.0, 55.0 };


    }
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
    public void heal()
    {
        this.currHealth = this.health;
    }

}

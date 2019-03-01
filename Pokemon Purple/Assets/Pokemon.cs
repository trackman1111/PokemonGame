﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Drawing;
using UnityEngine.UI;

public class Pokemon
{
    string type;
    public string name;

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

    public int health;
    public int currHealth;
    public int defence;
    public int attack;
    public int speed;
    public int level;
    public int exp;
    private int counter = 1;
    private IDictionary<string,double[]> pokemon;
    private IDictionary<string, double[]> movesPower;
    //private image image;


     public Pokemon(String name)
    {
        pokemon = new Dictionary<string, double[]>();
        // All arrays are in the format of [health, attack, defence, speed, level, exp]
        if (counter == 1)
        {
            //get pokemon number and an image for each pokemon
            pokemon.Add("Treecko", new double[] { 40.0, 45.0, 35.0, 65.0, 5.0, 0.0 });

            pokemon.Add("Grovyle", new double[] { 50.0, 65.0, 45.0, 85.0, 14.0, 0.0 });

            pokemon.Add("Sceptile", new double[] { 70.0, 85.0, 65.0, 105.0, 32.0, 0.0 });

            pokemon.Add("Torchic", new double[] { 45.0, 60.0, 40.0, 70.0, 5.0, 0.0 });

            pokemon.Add("Combusken", new double[] { 60.0, 85.0, 60.0, 85.0, 16.0, 0.0 });

            pokemon.Add("Blaziken", new double[] { 80.0, 120.0, 70.0, 110.0, 36.0, 0.0 });

            pokemon.Add("Mudkip", new double[] { 50.0, 70.0, 50.0, 50.0, 5.0, 0.0 });

            pokemon.Add("Marshtomp", new double[] { 70.0, 85.0, 70.0, 60.0, 18.0, 0.0 });

            pokemon.Add("Swampert", new double[] { 100.0, 110.0, 90.0, 85.0, 34.0, 0.0 });

            pokemon.Add("Poochyena", new double[] { 35.0, 55.0, 35.0, 30.0, 4.0, 0.0 });

            pokemon.Add("Mightyena", new double[] { 70.0, 90.0, 70.0, 60.0, 30.0, 0.0 });

            pokemon.Add("Zigzagoon", new double[] { 38.0, 30.0, 41.0, 30.0, 3.0, 0.0 });

            pokemon.Add("Linoone", new double[] { 78.0, 70.0, 61.0, 50.0, 25.0, 0.0 });

            pokemon.Add("Kyogre", new double[] { 100.0, 100.0, 90.0, 150.0, 45.0, 0.0 });

            pokemon.Add("Groudon", new double[] { 100.0, 150.0, 140.0, 90.0, 45.0, 0.0 });

            pokemon.Add("Rayquaza", new double[] { 625.0, 450.0, 817.0, 999.0, 70.0, 0.0 });

            counter++;
        }
        this.name = name;
        if (pokemon.ContainsKey(name))
        {
            double[] pokemonArrayStats = pokemon[name];
            this.health = (int)pokemonArrayStats[0];
            this.currHealth = (int)pokemonArrayStats[0];
            this.attack = (int)pokemonArrayStats[1];
            this.defence = (int)pokemonArrayStats[2];
            this.speed = (int)pokemonArrayStats[3];
            this.level = (int)pokemonArrayStats[4];
            this.exp = (int)pokemonArrayStats[5];
        }
        else
        {
            throw new Exception("It did not work!  :(");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        pokedex();
    }
    //return a string array and it should have a new parameter int that represents the level
    public string[] makeMoves(string type, int level)
    {

        if (type.Equals("Water"))
        {
            if(level <= 10)
            {
                string[] beginWaterMoves = {"Tackle", "Water Gun", "Defence Curl", "Bubble" };
                return beginWaterMoves;
            }
            else if(level <= 20)
            {
                string[] middleWaterMoves = { "Water Gun", "Bubble", "Defence Curl", "Surf" };
                return middleWaterMoves;
            }
            else
            {
                string[] endWaterMoves = { "Bubble", "Defence Curl", "Surf", "Hydro Pump" };
                return endWaterMoves;
            }
        }
        else if (type.Equals("Fire"))
        {
            if( level <= 10 )
            {
                string[] beginFireMoves = { "Scratch", "Ember", "Growl", "Quick Attack" };
                return beginFireMoves;
            }
            else if( level <= 20 )
            {
                string[] middleFireMoves = { "Ember", "Growl", "Flamethrower", "Quick Attack"};
                return middleFireMoves;
            }
            else
            {
                string[] endFireMoves = { "Quick Attack", "Growl", "Flamethrower", "Fire Blast" };
                return endFireMoves;
            }
        }
        else if (type.Equals("Grass"))
        {
            if( level <= 10)
            {
                string[] beginGrassMoves = { "Peck", "Leech Seed", "Growl", "Razor Leaf" };
                return beginGrassMoves;
            }
            else if( level <= 20 )
            {
                string[] middleGrassMoves = { "Leech Seed", "Growl", "Razor Leaf", "Gigadrain" };
                return middleGrassMoves;
            }
            else
            {
                string[] endGrassMoves = { "Leech Seed", "Razor Leaf", "Gigadrain", "Solar Beam" };
                return endGrassMoves;
            }
        }
        else if (type.Equals("Ground"))
        {
            if( level <= 10 )
            {
                string[] beginGroundMoves = { "Tackle", "Bulk Up", "Mud Slap", "Dig" };
                return beginGroundMoves;
            }
            else if( level <= 20 )
            {
                string[] middleGroundMoves = { "Bulk Up", "Mud Slap", "Dig", "Mud Bomb" };
                return middleGroundMoves;
            }
            else
            {
                string[] endGroundMoves = { "Bulk Up", "Dig", "Mud Bomb", "Earthquake" };
                return endGroundMoves;
            }
        }
        else if (type.Equals("Electric"))
        {
            if( level <= 10 )
            {
                string[] beginElectricMoves = { "Quick Attack", "Charge", "Thunderbolt", "Shock Wave" };
                return beginElectricMoves;
            }
            else if( level <= 20 )
            {
                string[] middleElectricMoves = { "Quick Attack", "Charge", "Thunderbolt", "Spark" };
                return middleElectricMoves;
            }
            else
            {
                string[] endElectricMoves = { "Quick Attack", "Charge", "Spark", "Thunder" };
                return endElectricMoves;
            }
        }
        else
        {
            string[] randomMoves = { "DragonBreath", "Iron Tail", "Ice Beam", "Confuse Ray" };
            return randomMoves;
        }
    }
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
   public void pokedex()
   {

        // Have to display this on the screen when asked
        List<string> pokemonNames = new List<string>(this.pokemon.Keys);
        if(Input.GetKeyDown(KeyCode.H))
        {
            for(int i = 0; i < pokemonNames.Count; i++)
            {
                //print(pokemonNames[i]);
            }
        }
    }
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
   public double[] getStats(String q)
    {
        if(pokemon.ContainsKey(q) || q != null)
        {
            return pokemon[q];
        }
        else
        {
            throw new System.ArgumentException("This pokemon does not exist colton. First letter should be capital.");
        }
    }
}

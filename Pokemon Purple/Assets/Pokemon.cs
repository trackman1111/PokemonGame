using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Drawing;

public class Pokemon : MonoBehaviour
{
    string type;
    public string name;
    public int health;
    private int defence;
    private int attack;
    private int speed;
    public int level;
    private int exp;
    public Sprite treecko;
    private IDictionary<string,double[]> pokemon;
    //private image image;


     public Pokemon(String name)
    {
        this.name = name;

    }
    // Start is called before the first frame update
    void Start()
    {
        pokemon = new Dictionary<string,double[]>();
        // All arrays are in the format of [health, attack, defence, speed, level, exp]

        //get pokemon number and an image for each pokemon
        double[] tree = {40.0, 45.0, 35.0, 65.0, 5.0, 0.0};
        pokemon.Add("Treecko", tree);
          
        double[] grov = { 50.0, 65.0, 45.0, 85.0, 14.0, 0.0 };
        pokemon.Add("Grovyle", grov); 

        double[] scep = { 70.0, 85.0, 65.0, 105.0, 32.0, 0.0 };
        pokemon.Add("Sceptile", scep);

        double[] torc = { 45.0, 60.0, 40.0, 70.0, 5.0, 0.0 };
        pokemon.Add("Torchic", torc);

        double[] comb = { 60.0, 85.0, 60.0, 85.0, 16.0, 0.0 };
        pokemon.Add("Combusken", comb);

        double[] blaz = { 80.0, 120.0, 70.0, 110.0, 36.0, 0.0 };
        pokemon.Add("Blaziken", blaz);

        double[] mudk = { 50.0, 70.0, 50.0, 50.0, 5.0, 0.0 };
        pokemon.Add("Mudkip", mudk);

        double[] mars = { 70.0, 85.0, 70.0, 60.0, 18.0, 0.0 };
        pokemon.Add("Marshtomp", mars);

        double[] swam = { 100.0, 110.0, 90.0, 85.0, 34.0, 0.0 };
        pokemon.Add("Swampert", swam);

        double[] pooc = { 35.0, 55.0, 35.0, 30.0, 4.0, 0.0 };
        pokemon.Add("Poochyena", pooc);

        double[] migh = { 70.0, 90.0, 70.0, 60.0, 30.0, 0.0 };
        pokemon.Add("Mightyena", migh);

        double[] zigz = { 38.0, 30.0, 41.0, 30.0, 3.0, 0.0 };
        pokemon.Add("Zigzagoon", zigz);

        double[] lino = { 78.0, 70.0, 61.0, 50.0, 25.0, 0.0 };
        pokemon.Add("Linoone", lino);

        double[] kyog = { 100.0, 100.0, 90.0, 150.0, 45.0, 0.0 };
        pokemon.Add("Kyogre", kyog);

        double[] grou = { 100.0, 150.0, 140.0, 90.0, 45.0, 0.0 };
        pokemon.Add("Groudon", grou);

        double[] rayq = { 625.0, 450.0, 817.0, 999.0, 70.0, 0.0 };
        pokemon.Add("Rayquaza", rayq);




    }

    // Update is called once per frame
    void Update()
    {
        pokedex();
    }
    //return a string array and it should have a new parameter int that represents the level
    public string[] makeMoves(string type, int level)
    {
        string[] temp = { "" };
        return temp;

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
            }
            string[] fireTypeMoves = { "Quick Attack", "Ember", "Flamethrower", "Growl" };
            string[] fireSupportMoves = { "Growl", "", "" };
        }
        else if (type.Equals("Grass"))
        {
            string[] grassTypeMoves = { "Peck", "Razor Leaf", "Gigadrain", "Solar Beam" };
            string[] grassSupportMoves = { "", "", "" };
        }
        else if (type.Equals("Ground"))
        {
            string[] groundTypeMoves = { "Tackle", "Mud Slap", "Dig", "Earthquake" };
            string[] groundSupportMoves = { "", "", "" };
        }
        else if (type.Equals("Electric"))
        {
            string[] electricTypeMoves = { "Quick Attack", "Thunderbolt", "Spark", "Thunder" };
            string[] electricSupportMoves = { "", "", "" };
        }
    }
   public void pokedex()
    {

        // Have to display this on the screen when asked
        List<string> pokemonNames = new List<string>(this.pokemon.Keys);
        if(Input.GetKeyDown(KeyCode.H))
        {
            for(int i = 0; i < pokemonNames.Count; i++)
            {
                print(pokemonNames[i]);
            }
        }
    }
   public string getImage(String q)
    {
        return q + ".png";
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

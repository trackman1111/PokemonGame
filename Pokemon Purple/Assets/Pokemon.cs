using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Drawing;

public class Pokemon : MonoBehaviour
{
    string type;
    string name;
    private int health;
    private int defence;
    private int attack;
    private int speed;
    private int level;
    private int exp;
    public Sprite treecko;
    private IDictionary<string,double[]> pokemon;
    //private image image;
    // Start is called before the first frame update
    void Start()
    {
        pokemon = new Dictionary<string,double[]>();
        // All arrays are in the format of [health, defence, attack, speed, level, exp]

        //get pokemon number and an image for each pokemon
        double[] tree = {10.0, 15.0, 11.0, 30.0, 25.0, 32.0};
        pokemon.Add("Treecko", tree);
          

        double[] grov = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Grovyle", grov); 

        double[] scep = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Sceptile", scep);

        double[] torc = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Torchic", torc);

        double[] comb = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Combusken", comb);

        double[] blaz = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Blaziken", blaz);

        double[] mudk = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Mudkip", mudk);

        double[] mars = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Marshtomp", mars);

        double[] swam = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Swampert", swam);

        double[] pooc = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Poochyena", pooc);

        double[] migh = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Mightyena", migh);

        double[] zigz = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Zigzagoon", zigz);

        double[] lino = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Linoone", lino);

        double[] kyog = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Kyogre", kyog);

        double[] grou = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Groudon", grou);

        double[] rayq = { 10.0, 15.0, 11.0, 30.0, 25.0, 32.0 };
        pokemon.Add("Rayquaza", rayq);

    }

    // Update is called once per frame
    void Update()
    {
        pokedex();
    }
    void makeMoves(string type)
    {
        if (type.Equals("Water"))
        {
            string[] waterTypeMoves = { "Tackle", "Water Gun", "Surf", "Hydro Pump" };
            string[] waterSupportMoves = { "Defence Curl", "", "" };
        }
        else if (type.Equals("Fire"))
        {
            string[] fireTypeMoves = { "Scratch", "Ember", "Flamethrower", "Fire Blast" };
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
    void pokedex()
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
    string getImage(String q)
    {
        return q + ".png";
    }
    
    double[] getStats(String name)
    {
        return pokemon[name];
    }
}

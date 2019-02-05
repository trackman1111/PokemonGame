using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private IDictionary<string,double[]> pokemon;
    //private image image;
    // Start is called before the first frame update
    void Start()
    {
        pokemon = new Dictionary<string,double[]>();
        // All arrays are in the format of [health, defence, attack, speed, level, exp]
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


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void makeMoves(string type, int slot)
    {
        if (type.Equals("Water"))
        {

  //          pokemon[slot, 1] = "Tackle";
    //        pokemon[slot, 2] = "Tail Whip";
    //        pokemon[slot, 3] = "Bubble";
        }
        else if (type.Equals("Fire"))
        {
    //        pokemon[slot, 1] = "Scratch";
    //        pokemon[slot, 2] = "Growl";
    //        pokemon[slot, 3] = "Ember";
        }
        else if (type.Equals("Grass"))
        {
    //        pokemon[slot, 1] = "Growl";
    //        pokemon[slot, 2] = "Tackle";
    //        pokemon[slot, 3] = "Vine Whip";
        }
        else if (type.Equals("Ground"))
        {
    //        pokemon[slot, 1] = "Defense Curl";
    //        pokemon[slot, 2] = "Scratch";
    //        pokemon[slot, 3] = "Sand Attack";
        }
        else if (type.Equals("Electric"))
        {
    //        pokemon[slot, 1] = "Growl";
    //       pokemon[slot, 2] = "Tail Whip";
   //         pokemon[slot, 3] = "Thunder Shock";
        }
    }
}

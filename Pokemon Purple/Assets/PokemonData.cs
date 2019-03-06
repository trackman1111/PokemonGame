﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonData 
{
    // private int counter = 1;
    private Dictionary<string, double[]> pokemon;
    List<string> pokeNames;
    List<string> wildPokemon;
    private IDictionary<string, double[]> movesPower;
    // Start is called before the first frame update
    public PokemonData()
    {
        pokemon = new Dictionary<string, double[]>();
        createPokemon();
        pokeNames = new List<string>(pokemon.Keys);
        wildPokemon = new List<string>();
        createWildPokemon();

    }
    public void createWildPokemon()
    {
        for (int i = 0; i < pokemon.Count; i++)
        {
            foreach (string name in pokemon.Keys)
            {
                if (pokemon[name][6] != 0)
                {
                    wildPokemon.Add(name);
                }
            }
        }
    }
    public void createPokemon()
    {
        pokemon.Add("Treecko", new double[] { 40.0, 45.0, 35.0, 65.0, 5.0, 0.0, 0 });

        pokemon.Add("Grovyle", new double[] { 50.0, 65.0, 45.0, 85.0, 14.0, 0.0, 0 });

        pokemon.Add("Sceptile", new double[] { 70.0, 85.0, 65.0, 105.0, 32.0, 0.0, 0 });

        pokemon.Add("Torchic", new double[] { 45.0, 60.0, 40.0, 70.0, 5.0, 0.0, 0 });

        pokemon.Add("Combusken", new double[] { 60.0, 85.0, 60.0, 85.0, 16.0, 0.0, 0 });

        pokemon.Add("Blaziken", new double[] { 80.0, 120.0, 70.0, 110.0, 36.0, 0.0, 0 });

        pokemon.Add("Mudkip", new double[] { 50.0, 70.0, 50.0, 50.0, 5.0, 0.0, 0 });

        pokemon.Add("Marshtomp", new double[] { 70.0, 85.0, 70.0, 60.0, 18.0, 0.0, 0 });

        pokemon.Add("Swampert", new double[] { 100.0, 110.0, 90.0, 85.0, 34.0, 0.0, 0 });

        pokemon.Add("Poochyena", new double[] { 35.0, 55.0, 35.0, 30.0, 4.0, 0.0, 0.1 });

        pokemon.Add("Mightyena", new double[] { 70.0, 90.0, 70.0, 60.0, 30.0, 0.0, 0.05 });

        pokemon.Add("Zigzagoon", new double[] { 38.0, 30.0, 41.0, 30.0, 3.0, 0.0, 0.2 });

        pokemon.Add("Linoone", new double[] { 78.0, 70.0, 61.0, 50.0, 25.0, 0.0, 0.1 });

        pokemon.Add("Kyogre", new double[] { 100.0, 100.0, 90.0, 150.0, 45.0, 0.0, 0 });

        pokemon.Add("Groudon", new double[] { 100.0, 150.0, 140.0, 90.0, 45.0, 0.0, 0 });

        pokemon.Add("Rayquaza", new double[] { 625.0, 450.0, 817.0, 999.0, 70.0, 0.0, 0 });
    }
    public string[] makeMoves(string type, int level)
    {

        if (type.Equals("Water"))
        {
            if (level <= 10)
            {
                string[] beginWaterMoves = { "Tackle", "Water Gun", "Defence Curl", "Bubble" };
                return beginWaterMoves;
            }
            else if (level <= 20)
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
            if (level <= 10)
            {
                string[] beginFireMoves = { "Scratch", "Ember", "Growl", "Quick Attack" };
                return beginFireMoves;
            }
            else if (level <= 20)
            {
                string[] middleFireMoves = { "Ember", "Growl", "Flamethrower", "Quick Attack" };
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
            if (level <= 10)
            {
                string[] beginGrassMoves = { "Peck", "Defence Curl", "Growl", "Razor Leaf" };
                return beginGrassMoves;
            }
            else if (level <= 20)
            {
                string[] middleGrassMoves = { "Defence Curl", "Growl", "Razor Leaf", "Gigadrain" };
                return middleGrassMoves;
            }
            else
            {
                string[] endGrassMoves = { "Defence Curl", "Razor Leaf", "Gigadrain", "Solar Beam" };
                return endGrassMoves;
            }
        }
        else if (type.Equals("Ground"))
        {
            if (level <= 10)
            {
                string[] beginGroundMoves = { "Tackle", "Bulk Up", "Mud Slap", "Dig" };
                return beginGroundMoves;
            }
            else if (level <= 20)
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
            if (level <= 10)
            {
                string[] beginElectricMoves = { "Quick Attack", "Charge", "Thunderbolt", "Shock Wave" };
                return beginElectricMoves;
            }
            else if (level <= 20)
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
            string[] randomMoves = { "DragonBreath", "Iron Tail", "Ice Beam", "Shadow Ball" };
            return randomMoves;
        }
    }
    public void movePower()
    {
        movesPower = new Dictionary<string, double[]>();
        // key is the move and dictionary [damage, defenceBoost, attackBoost, accuracy, currpp, pp]

        // start of water type moves

        movesPower.Add("Tackle", new double[] { 30.0, 0.0, 0.0, 100.0, 35.0, 35.0 } );
        movesPower.Add("Water Gun", new double[] { 35.0, 0.0, 0.0, 100.0, 25.0, 25.0 } );
        movesPower.Add("Defence Curl", new double[] { 0.0, 15.0, 0.0, 100.0, 35.0, 35.0 } );
        movesPower.Add("Bubble", new double[] { 45.0, 0.0, 0.0, 99.0, 25.0, 25.0 } );
        movesPower.Add("Surf", new double[] { 60.0, 0.0, 0.0, 95.0, 15.0, 15.0 } );
        movesPower.Add("Hydro Pump", new double[] { 85.0, 0.0, 0.0, 80.0, 10.0, 10.0 } );

        // start of fire type moves

        movesPower.Add("Scratch", new double[] { 30.0, 0.0, 0.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Ember", new double[] { 35.0, 0.0, 0.0, 100.0, 25.0, 25.0 } );
        movesPower.Add("Growl", new double[] { 0.0, 0.0, 15.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Quick Attack", new double[] { 35.0, 0.0, 0.0, 100.0, 35.0, 35.0 } );
        movesPower.Add("Flamethrower", new double[] { 60.0, 0.0, 0.0, 95.0, 15.0, 15.0 } );
        movesPower.Add("Fire Blast", new double[] { 75.0, 0.0, 0.0, 85.0, 10.0, 10.0 } );

        // start of grass type moves
        
        movesPower.Add("Peck", new double[] { 30.0, 0.0, 0.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Defence Curl", new double[] { 0.0, 15.0, 0.0, 100.0, 35.0, 35.0 } );
        movesPower.Add("Growl", new double[] { 0.0, 0.0, 15.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Razor Leaf", new double[] { 35.0, 0.0, 0.0, 100.0, 25.0, 25.0 } );
        movesPower.Add("Giga Drain", new double[] { 45.0, 0.0, 10.0, 95.0, 15.0, 15.0 } );
        movesPower.Add("Solar Beam", new double[] { 75.0, 0.0, 0.0, 85.0, 10.0, 10.0 } );

        // start of ground type moves
        
        //movesPower.Add("Tackle", new double[]  { 30.0, 0.0, 0.0, 100.0, 35.0, 35.0 } );
        movesPower.Add("Bulk Up", new double[] { 0.0, 15.0, 15.0, 100.0, 15.0, 15.0 });
        movesPower.Add("Mud Slap", new double[] { 30.0, 0.0, 0.0, 100.0, 30.0, 30.0 });
        movesPower.Add("Dig", new double[] { 45.0, 0.0, 0.0, 100.0, 20.0, 20.0 });
        movesPower.Add("Mud Bomb", new double[] { 60.0, 0.0, 0.0, 100.0, 15.0, 15.0 });
        movesPower.Add("Earthquake", new double[] { 75.0, 0.0, 0.0, 90.0, 10.0, 10.0 });

        // start of eletric type moves
        
        //movesPower.Add("Quick Attack", new double[] { 35.0, 0.0, 0.0, 100.0, 35.0, 35.0 } );
        movesPower.Add("Charge", new double[] { 0.0, 15.0, 5.0, 100.0, 30.0, 30.0} );
        movesPower.Add("Thunderbolt", new double[] { 30.0, 0.0, 0.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Shock Wave", new double[] { 45.0, 0.0, 0.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Spark", new double[] { 45.0, 10.0, 0.0, 100.0, 30.0, 30.0 } );
        movesPower.Add("Thunder", new double[] { 60.0, 0.0, 0.0, 100.0, 30.0, 30.0 } );

        // start of other moves
        //"DragonBreath", "Iron Tail", "Ice Beam", "Shadow Ball"
        movesPower.Add("DragonBreath", new double[] { 40.0, 40.0, 40.0, 100.0, 10.0, 10.0 } );
        movesPower.Add("Iron Tail", new double[] { 70.0, 0.0, 0.0, 100.0, 10.0, 10.0 } );
        movesPower.Add("Ice Beam", new double[] { 70.0, 0.0, 0.0, 100.0, 10.0, 10.0 } );
        movesPower.Add("Shadow Ball", new double[] { 75.0, 0.0, 0.0, 100.0, 10.0, 10.0 });
    }
        // Update is called once per frame
    public double[] makePokemon(string name)
    {
        double[] pokemonStats = pokemon[name];
        return pokemonStats;
    }
    public string getWildPokemon()
    {
        return wildPokemon[(int)(Random.value * wildPokemon.Count)];
    }
    public double getChances(string name)
    {
        return pokemon[name][6];
    }
}

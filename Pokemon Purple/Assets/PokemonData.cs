using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonData 
{
    // private int counter = 1;
    private Dictionary<string, double[]> pokemon;
    // Start is called before the first frame update
    public PokemonData()
    {
        pokemon = new Dictionary<string, double[]>();

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
    }
    // Update is called once per frame
    public double[] makePokemon(string name)
    {
        double[] pokemonStats = pokemon[name];
        return pokemonStats;
    }
    public string getRandomPokemon()
    {
        List<string> pokeNames = new List<string>(pokemon.Keys);
        return pokeNames[(int)(Random.value * pokeNames.Count)];
    }
}

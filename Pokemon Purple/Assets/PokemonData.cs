using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonData : MonoBehaviour
{
    // private int counter = 1;
    public Pokemon caller;
    // Start is called before the first frame update
    void Start()
    {
       // if(counter == 1)
      //  {
      //      makePokemon();
      //      counter++;
     //   }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void makePokemon()
    {
        Dictionary<string, double[]> pokemon = new Dictionary<string, double[]>();

        // All arrays are in the format of [health, attack, defence, speed, level, exp]
        double[] test = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        pokemon.Add("", test);

        double[] tree = { 40.0, 45.0, 35.0, 65.0, 5.0, 0.0 };
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
}

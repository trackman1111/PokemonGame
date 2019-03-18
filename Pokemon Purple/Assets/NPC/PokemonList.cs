using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PokemonList
{
    public PokemonList(string[] pokemon)
    {
        this.pokemon = pokemon;
    }
    [TextArea]
    public string[] pokemon;
}

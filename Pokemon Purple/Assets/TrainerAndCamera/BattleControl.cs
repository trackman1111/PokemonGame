using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleControl
{
    private Trainer t;
    private bool yourTurn;
    private List<Pokemon> pokemonList = new List<Pokemon>();
    private int currEnemyPokemon = 0;
    public BattleCanvasScript battleCanvas;
    public PokemonData pokeData;
    // Start is called before the first frame update
    public BattleControl(NPC enemy)
    {
       //pokemonList = NPC.getPokemon();
    }
    public  BattleControl(Pokemon p, Trainer t)
    {
         pokemonList.Add(p);
         this.t = t;
    }

    public bool getTurn()
    {
        return yourTurn;
    }
    public void changeTurn()
    {
        yourTurn = !yourTurn;
    }
    public void applyMove(string move)
    {
        double[] temp = pokeData.getMovePower(move);
        //[damage, defenceBoost, attackBoost, accuracy, currpp, pp]
        int randomForAccuracy = (int)Random.Range(0, 100);
 
        if (temp[3] >= randomForAccuracy)
        {
            if (pokemonList[currEnemyPokemon].currHealth - (int)temp[0] > 0)
            {
                pokemonList[currEnemyPokemon].currHealth = pokemonList[currEnemyPokemon].currHealth - (int)temp[0];
            }
            else
            {
                swapPokemon();
            }
            t.pokemon[0].defence = t.pokemon[0].defence + (int)temp[1];
            t.pokemon[0].attack = t.pokemon[0].attack + (int)temp[2];
            temp[4]--;
        }
    }
    public void swapPokemon()
    {
        if (pokemonList[currEnemyPokemon + 1] != null)
        {  
            pokemonList[currEnemyPokemon] = pokemonList[currEnemyPokemon + 1];
            battleCanvas.setEnemy(pokemonList[currEnemyPokemon]);
        }
        else
        {
                battleCanvas.exitBattle();
        }
    }
    public void faint()
    {

    }
}

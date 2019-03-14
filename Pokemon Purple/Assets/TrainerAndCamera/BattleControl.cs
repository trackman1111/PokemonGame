using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleControl
{
    private Trainer t;
    private bool yourTurn;
    private Pokemon[] pokemonList;
    private int currEnemyPokemon = 0;
    public BattleCanvasScript battleCanvas;
    // Start is called before the first frame update
    public BattleControl(NPC enemy)
    {
       //pokemonList = NPC.getPokemon();
    }
    public  BattleControl(Pokemon p)
    {
        pokemonList[0] = p;
    }

    public bool getTurn()
    {
        return yourTurn;
    }
    public void changeTurn()
    {
        yourTurn = !yourTurn;
    }

    public void swapPokemon()
    {
        if (pokemonList[currEnemyPokemon].currHealth < 0)
        {
            if (pokemonList[currEnemyPokemon + 1] != null)
            {
                pokemonList[currEnemyPokemon] = pokemonList[currEnemyPokemon + 1];
                battleCanvas.setEnemy(pokemonList[currEnemyPokemon]);
            }
            else
            {
                //battleCanvas.endBattle();
            }

        }
    }
    public void faint()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleControl
{
    private Trainer t;
    private List<Pokemon> pokemonList = new List<Pokemon>();
    private int currEnemyPokemon = 0;
    private NPC nPC;
    private bool canBattle = true;
    private BattleCanvasScript battleCanvas;
    public PokemonData pokeData = new PokemonData();
    private int counter;
    // Start is called before the first frame update
    public BattleControl(NPC enemy, Trainer t, BattleCanvasScript b)
    {
        nPC = enemy;
        pokemonList = enemy.getPokemon();
        battleCanvas = b;
        this.t = t;
    }
    public BattleControl(Pokemon p, Trainer t, BattleCanvasScript b)
    {
        pokemonList.Add(p);
        this.t = t;
        battleCanvas = b;
    }

    public double[] applyMove(string move)
    {
        double[] temp = pokeData.getMovePower(move);
        //[damage, defenceBoost, attackBoost, accuracy, currpp, pp]
        int randomForAccuracy = (int)Random.Range(0, 100);

        if (pokemonList[currEnemyPokemon].speed >= t.pokemon[0].speed)
        {
          //  if (canBattle)
          //  {
          //      enemyTurnFight();
          //  }

            // next line is the start of our pokemon attacking
            if(temp[3] >= randomForAccuracy && canBattle)
            {
                ourTurnFighting(move);
            }
        }
        else 
        {
            if(temp[3] >= randomForAccuracy && canBattle)
            {
                ourTurnFighting(move);
            }
            // next line is the start of the enemy attacking
       //     if(pokemonList[currEnemyPokemon].health > 0 && canBattle)
       //     {
       //         enemyTurnFight();
       //     }
        }
        canBattle = true;
        return temp;
    }
    public void swapPokemon()
    { 
        if (currEnemyPokemon + 1 < pokemonList.Count)
        {
            currEnemyPokemon++;
            battleCanvas.setEnemy(pokemonList[currEnemyPokemon]);
   
        }
        else
        {
            if (nPC != null)
            {
                nPC.fullHealth();
            }
            battleCanvas.exitBattle();
        }
        canBattle = false;
    }

    public void faint()
    {
        
    }

    public void ourTurnFighting(string q)
    {
        int randomForAccuracy = (int)Random.Range(0, 100);
        double[] temp = pokeData.getMovePower(q);
        int colton = actualDamageDone(pokemonList[currEnemyPokemon].defence, t.pokemon[0].attack, (int)temp[0], t.pokemon[0].level, pokemonList[currEnemyPokemon].level);


        if (pokemonList[currEnemyPokemon].currHealth - colton > 0)
        {
            pokemonList[currEnemyPokemon].currHealth = pokemonList[currEnemyPokemon].currHealth - colton;
        }
        else
        {
            pokemonList[currEnemyPokemon].currHealth = 0;
            swapPokemon();
        }
        t.pokemon[0].defence += (int)temp[1];
        t.pokemon[0].attack += (int)temp[2];

        temp[4]--;
    }

    public void enemyTurnFight()
    {
        int randomForAccuracy = (int)Random.Range(0, 100);
        double[] tempForEnemyPokemon;
        if (randomForAccuracy >= 75)
        {
            tempForEnemyPokemon = pokeData.getMovePower(pokemonList[currEnemyPokemon].moveOne);
            battleCanvas.printEnemyMove(pokemonList[currEnemyPokemon].moveOne, tempForEnemyPokemon);
        }
        else if (randomForAccuracy >= 50)
        {
            tempForEnemyPokemon = pokeData.getMovePower(pokemonList[currEnemyPokemon].moveTwo);
            battleCanvas.printEnemyMove(pokemonList[currEnemyPokemon].moveTwo, tempForEnemyPokemon);
        }
        else if (randomForAccuracy >= 25)
        {
            tempForEnemyPokemon = pokeData.getMovePower(pokemonList[currEnemyPokemon].moveThree);
            battleCanvas.printEnemyMove(pokemonList[currEnemyPokemon].moveThree, tempForEnemyPokemon);
        }
        else
        {
            tempForEnemyPokemon = pokeData.getMovePower(pokemonList[currEnemyPokemon].moveFour);
            battleCanvas.printEnemyMove(pokemonList[currEnemyPokemon].moveFour, tempForEnemyPokemon);
        }


        int brandon = actualDamageDone(t.pokemon[0].defence, pokemonList[currEnemyPokemon].attack, (int)tempForEnemyPokemon[0], pokemonList[currEnemyPokemon].level, t.pokemon[0].level);
        

        if (t.pokemon[0].currHealth - brandon > 0)
        {
        
            battleCanvas.takeDamage(false, brandon);
        }
        else
        {
            battleCanvas.takeDamage(true, (int)tempForEnemyPokemon[0]);

            if (battleCanvas.allDead())
            {
                if (nPC != null)
                {
                    nPC.fullHealth();
                }
                t.reset();
                canBattle = false;
                battleCanvas.exitBattle();
            }
        }
        pokemonList[currEnemyPokemon].defence += (int)tempForEnemyPokemon[1];
        pokemonList[currEnemyPokemon].attack += (int)tempForEnemyPokemon[2];
        tempForEnemyPokemon[4]--;
    }


    public int actualDamageDone(double defence, double attack, double power, double otherLevel, double ourLevel)
    {
        if(power == 0)
        {
            return 0;
        }
        else
        {
            double first = (int)(ourLevel - otherLevel) / 5 + 2;
            int goatAlg= (int)((power * (attack / defence) * first / 50) + 2);
            return goatAlg;
        }
        // multiply the whole return statement by the modifier to finish this later
    }
}

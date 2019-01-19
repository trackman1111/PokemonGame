using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ArrayList pokemon = new ArrayList(6);
    ArrayList moves = new ArrayList();
    ArrayList bag = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        for ( int i = 0; i < pokemon.Count; i++ )
        {
           // makeMoves( pokemon[i].type );
        }
    }

    // Update is called once per frame
    void Update()
    {
     // if ( im on a bush )
        {
            int chanceOfSpawn = Random.Range(1, 100);
            if ( chanceOfSpawn  >= 90 )
            {
                encounter();
            }
        }
    }

    void makeMoves( string type)
    {
        if ( type.Equals("Water") ) {
            moves.Add("Tackle");
            moves.Add("Tail Whip");
            moves.Add("Bubble");
        }
        else if (type.Equals("Fire")){
            moves.Add("Scratch");
            moves.Add("Growl");
            moves.Add("Ember");
        }
        else if (type.Equals("Grass")){
            moves.Add("Growl");
            moves.Add("Tackle");
            moves.Add("Vine Whip");
        }
        else if (type.Equals("Ground")){
            moves.Add("Defense Curl");
            moves.Add("Scratch");
            moves.Add("Sand Attack");
        }
        else if (type.Equals("Electric")){ 
            moves.Add("Growl");
            moves.Add("Tail Whip");
            moves.Add("Thunder Shock");
        }
    }


    // this method occurs 10% of the time when a trainer is in a bush
    void encounter()
    {

    }
}

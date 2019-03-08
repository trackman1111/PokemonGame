using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    // make 4 game objects pokemart, health center
    public float xCoord;
    public float yCoord;

    // Start is called before the first frame update

    // when u collide with something a canvas pops up and calls the add object on the trainer
    public void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Movement>().setPosition(xCoord, yCoord);
    }

}

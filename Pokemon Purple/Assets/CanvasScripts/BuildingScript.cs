﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    // make 4 game objects pokemart, health center
    public GameObject buildingCanvas;
    // Start is called before the first frame update

    // when u collide with something a canvas pops up and calls the add object on the trainer
    public void OnCollisionEnter2D(Collision2D collision)
    {
        buildingCanvas.SetActive(true);
        FindObjectOfType<Movement>().setStasis(true);
    }
    public void closeMenu()
    {
        buildingCanvas.SetActive(false);
    }

}
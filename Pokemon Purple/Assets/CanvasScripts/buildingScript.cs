using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingScript : MonoBehaviour
{
    // make 4 game objects pokemart, health center
    public GameObject healthCenter;
    public GameObject pokeMart;
    public GameObject gym;
    public GameObject other;
    public GameObject PokeCenter;
    // Start is called before the first frame update
    void Start()
    {
        healthCenter.SetActive(false);
        pokeMart.SetActive(false);
        gym.SetActive(false);
        other.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // when u collide with something a canvas pops up and calls the add object on the trainer
    public void OnCollisionEnter2D(Collision2D collision)
    {
        PokeCenter.SetActive(true);
        FindObjectOfType<Movement>().setStasis(true);
    }
    public void closeMenu()
    {
        PokeCenter.SetActive(false);
    }

}

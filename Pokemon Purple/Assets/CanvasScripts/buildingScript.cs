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
}

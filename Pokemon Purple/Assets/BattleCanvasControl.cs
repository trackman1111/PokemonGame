using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleCanvasControl : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

        gameObject.GetComponent<SpriteRenderer>().sprite = enemy.GetComponent<SpriteRenderer>().sprite;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

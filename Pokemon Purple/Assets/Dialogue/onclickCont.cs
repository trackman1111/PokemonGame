﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onclickCont : MonoBehaviour
{
    private Button button;
    public KeyCode keycode;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.E) )
        {
            button.onClick.Invoke();
        }
    }
}
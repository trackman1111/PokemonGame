using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridmovement : MonoBehaviour
{
    Transform tr;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        tr = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && tr.position == pos)
            pos += Vector3.up;
    }
}

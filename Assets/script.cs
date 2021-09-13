using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    private BoxCollider2D tmp;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Um BASED?");
        Debug.Log(tmp.tag);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles collision
public class collision : MonoBehaviour
{
    public BoxCollider2D collider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.collider.tag);
        

    }

    void collisionHandle(string tag)
    {
        switch (tag)
        {
            case "Floor":
                break;
            case "Stairs":
                break;
            case "Rails":
                break;
                
            
        }
        
    } 

    private void OnCollisionEnter2D(Collision2D other)
    {
        collisionHandle(other.collider.tag);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    
    void Update() 
    {
        
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You bumped");    
    }
    
}

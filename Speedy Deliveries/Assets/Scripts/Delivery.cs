using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("You bumped");    
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Package"))
        {
            Debug.Log("You just take the package!");        
            Destroy(other.gameObject);  
            hasPackage = true;
        }
        else if(hasPackage &&other.CompareTag("Customer"))
        {
            Debug.Log("Well done you delivered your package!");   
            hasPackage = false;     
            Destroy(other.gameObject);  
        }
    }
}

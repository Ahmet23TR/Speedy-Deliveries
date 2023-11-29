using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Color secondColor = new Color(255,0,0); 
    [SerializeField] Color firstColor = new Color(255,255,255); 
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    [SerializeField] float timeToDestroy = 0.5f;
    bool hasPackage;

     void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("You just take the package!");        
            Destroy(other.gameObject, timeToDestroy);  
            hasPackage = true;
            spriteRenderer.color = secondColor;
        }
        else if(hasPackage && other.CompareTag("Customer"))
        {
            Debug.Log("Well done you delivered your package!");   
            hasPackage = false;     
            Destroy(other.gameObject, timeToDestroy);  
            spriteRenderer.color = firstColor;
        }
    }
}

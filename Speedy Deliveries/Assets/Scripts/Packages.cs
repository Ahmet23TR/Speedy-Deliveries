using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packages : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    bool hasPackage;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(spriteRenderer.sprite == gameObject)
        {
            Debug.Log("You just take the package! " );        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float slowSpeed = 20f;
    [SerializeField] float boostSpeed = 40f;
    [SerializeField] float speedDuration = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
        void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.CompareTag("Booster") && speedDuration > 0)
            {
                moveSpeed = boostSpeed;
                speedDuration -= Time.deltaTime;
                Destroy(other.gameObject);
            }
            else if(other.CompareTag("Bumper") && speedDuration > 0)
            {
                moveSpeed = slowSpeed;
                speedDuration -= Time.deltaTime;
                Destroy(other.gameObject);
            }
       
        }
}

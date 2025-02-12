using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    public float dragFactor = 5f;
    public AudioManager AM;

    private Rigidbody rb;

    //private AudioSource soundSource;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical"); // W/S or Up/Down arrows
        Vector3 moveDirection = transform.forward * move * speed;
        Debug.Log(move);
        if (Mathf.Abs(move) > .01)
        {
            rb.velocity = moveDirection;
            AM.stopIdleSound();
            AM.playMovingSound();
        }
        else
        {
            rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, dragFactor * Time.deltaTime);
            AM.stopMovingSound(); 
            AM.playIdleSound();

        }
          
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5f;
    public float dragFactor = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical"); // W/S or Up/Down arrows
        Vector3 moveDirection = transform.forward * move * speed;

        if (move != 0)
            rb.velocity = moveDirection;
        else
            rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, dragFactor * Time.deltaTime);
    }
}

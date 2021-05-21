 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;




public class PlayerController : MonoBehaviour
{
    // properties of rigidbody (the sphere)
    public Rigidbody rb;
    private float movementX, movementY;

    AudioSource[] sources;
    float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sources = GetComponents<AudioSource>();
    }

    void FixedUpdate() 
    {
        rb.AddForce(new Vector3(movementX, 0.0f, movementY) * speed);
    }

    // Update is called once per frame
    void Update()
    {
   

    }

    void OnMove(InputValue movementValue) 
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x; 
        movementY = movementVector.y;
        sources[0].Play();
    }

    void OnCollisionEnter (Collision collision)
    {
        sources[1].Play();
    }
}

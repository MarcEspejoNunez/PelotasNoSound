using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota1AudioController : MonoBehaviour
{
    AudioSource[] sources;
    Rigidbody rb;
    float speed= 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        sources = GetComponents<AudioSource>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       speed = rb.velocity.magnitude;
        if (speed > 0.05f)
        {
            sources[0].pitch = rb.velocity.magnitude * 4;
            sources[0].Play();
        }
        if (speed < 0.05f)
        {
            sources[0].Stop();
        }



       // print(speed);
    }
    void OnMove()
    {
        //sources[0].Play();
     
       

    }
    void OnCollisionEnter(Collision collision)
    {
        sources[1].Play();
    }
}

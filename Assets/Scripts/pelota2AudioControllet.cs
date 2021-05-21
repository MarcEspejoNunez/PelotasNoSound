using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota2AudioControllet : MonoBehaviour
{
    AudioSource[] sources2;
    Rigidbody rb2;
    float speed2 = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        sources2 = GetComponents<AudioSource>();
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed2 = rb2.velocity.magnitude;
        if (speed2 > 0.05f)
        {
            sources2[0].pitch = rb2.velocity.magnitude * 2;
            sources2[0].Play();
        }
        if (speed2 < 0.05f)
        {
            sources2[0].Stop();
        }
      
    }
    void OnCollisionEnter(Collision collision)
    {
        sources2[1].Play();
    }
}

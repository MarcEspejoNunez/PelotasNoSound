using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboAudioController : MonoBehaviour
{
    AudioSource sourceCubo;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        sourceCubo = GetComponent<AudioSource>();
        Renderer rend = GetComponent<Renderer>();
        Bounds bounds = rend.bounds;
        sourceCubo.pitch = 2.0f / bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        sourceCubo.Play();
    }
}

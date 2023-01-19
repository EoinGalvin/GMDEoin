using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Vector3 acceleration;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //acceleration = 9.8f * Vector3.down; // f = m.a
        if (Input.touchCount > 0){
            //acceleration += 15 * Vector3.up;
        }

        velocity += acceleration * Time.deltaTime; // v = u + a.t
        transform.position += velocity * Time.deltaTime; // s = u.t
    }

    internal void moveUp(){
        transform.position += Vector3.up;
    }

    internal void changeColour(Color colour){
        GetComponent<Renderer>().material.color = colour;
    }
}

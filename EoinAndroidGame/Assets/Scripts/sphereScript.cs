using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour, ITouchables
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTap()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void onDrag(Ray collidingRay)
    {
        throw new System.NotImplementedException();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ITouchables 
{
    void OnTap();

    void onDrag(Ray collidingRay);
  
}

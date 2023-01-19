using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //acceleration += 15 * Vector3.up;

            Touch[] currentTouches = Input.touches;
            Touch firstTouch = currentTouches[0];

            print(firstTouch.position);

            Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);
            Debug.DrawRay(ray.origin, 60 * ray.direction);

            RaycastHit hitInfo;
            if(Physics.Raycast(ray,out hitInfo)){
                //hitInfo.collider.gameObject.transform.position += Vector3.up;
                //hitInfo.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;

                CubeScript touchCube = hitInfo.transform.GetComponent<CubeScript>();
                touchCube.moveUp();
                touchCube.changeColour(Color.green);
            }
            if (Physics.Raycast(ray)){
                print("hit");
            }
            else{
                print("miss");
            }
        }
    }
}

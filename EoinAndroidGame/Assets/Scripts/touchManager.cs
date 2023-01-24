using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchManager : MonoBehaviour
{
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch[] currentTouches = Input.touches;
            Touch firstTouch = currentTouches[0];

            timer += Time.deltaTime;
            switch (firstTouch.phase)
            {
                case TouchPhase.Began:
                    timer = 0;
                    break;
                case TouchPhase.Ended:
                    if(timer <= 0.25){
                        touching(firstTouch);
                    }
                    else
                    {
                        //not a tap
                    }
                    break;
                case TouchPhase.Moved:
                    print("touch moved so not a touch");
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Canceled:
                    break;
            }

            /*
            print(firstTouch.position);

            Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);
            Debug.DrawRay(ray.origin, 60 * ray.direction);

            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo)) {

                //CubeScript touchCube = hitInfo.transform.GetComponent<CubeScript>();
                //touchCube.moveUp();
                //touchCube.ChangeColour(Color.green);

                ITouchables touchedObject = hitInfo.transform.GetComponent<ITouchables>();
                if (touchedObject != null)
                {
                    touchedObject.OnTap();
                }
                if(touchedObject is CubeScript)
                {
                    (touchedObject as CubeScript).cubeOnly();
                }
                
            } */

            
        }
    }
    public void touching(Touch firstTouch)
    {
        Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);
        Debug.DrawRay(ray.origin, 60 * ray.direction);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {

            //CubeScript touchCube = hitInfo.transform.GetComponent<CubeScript>();
            //touchCube.moveUp();
            //touchCube.ChangeColour(Color.green);

            ITouchables touchedObject = hitInfo.transform.GetComponent<ITouchables>();
            if (touchedObject != null)
            {
                touchedObject.OnTap();
            }
            if (touchedObject is CubeScript)
            {
                (touchedObject as CubeScript).cubeOnly();
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Touch touch;
    public float movespeed;

    void Start()
    {
        movespeed = 0.05f;
    }
    void Update()
    {
     if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z + touch.deltaPosition.x * movespeed);
            }
        }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    float speedH = 30.0f;
    public GameObject prop;
    public GameObject propBlured;
    private bool upGo = false;
    private bool downGo = false;
    Vector3 dir;

    void Start()
    {
        prop.SetActive(false);
        propBlured.SetActive(true);
        propBlured.transform.Rotate(1000 * Time.deltaTime, 0, 0);
        dir = Vector3.zero;
    }


    void Update()
    {
        propBlured.transform.Rotate(1000 * Time.deltaTime, 0, 0);
       
        dir.x = Input.acceleration.x;
        if (upGo == true)
        {
            if (downGo == true)
            {
                dir.z = 0;
            }

            else
            {
                dir.z = 1;
            }
        }
        else if (downGo == true)
        {
            dir.z = -1;
        }
        else
        {
            dir.z = 0;
        }

        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        dir *= Time.deltaTime;


        transform.Translate(dir * speedH);
    
    }
   
    public void moveDownStart()
    {
        downGo = true;
    }

    public void moveDownEnd()
    {
        downGo = false;
    }

    public void moveUpStart()
    {
        upGo = true;
    }

    public void moveUpEnd()
    {
        upGo = false;
    }

}

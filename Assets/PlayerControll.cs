using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    float speed = 30.0f;
    public GameObject prop;
    public GameObject propBlured;
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
        dir.z = Input.acceleration.y;

        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        dir *= Time.deltaTime;


        transform.Translate(dir * speed);
    
    }
}

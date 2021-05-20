using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControll : MonoBehaviour
{
    float speedH = 30.0f;
    public GameObject prop;
    public GameObject propBlured;
    public GameObject explosion;
    private bool upGo = false;
    private bool downGo = false;
    public GameObject alive;
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
        if (Input.GetKey(KeyCode.W) && (transform.position.z < 4))
        {
            if (Input.GetKey(KeyCode.S))
            {
                dir.z = 0;
            }

            else
            {
                dir.z = 0.7f;
            }
        }
        else if (Input.GetKey(KeyCode.S) && (transform.position.z > -4))
        {
            dir.z = -0.7f;
        }
        else
        {
            dir.z = 0;
        }
        if (Input.GetKey(KeyCode.A) && (transform.position.x > -16))
        {
            if (Input.GetKey(KeyCode.D))
            {
                dir.x = 0;
            }

            else
            {
                dir.x = -0.7f;
            }
        }
        else if (Input.GetKey(KeyCode.D) && (transform.position.x < 16))
        {
            dir.x =0.7f;
        }
        else
        {
            dir.x= 0;
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



    public void death()
    {
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        alive.SetActive(true);

    }
    
}

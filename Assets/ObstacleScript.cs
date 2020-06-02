using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public GameObject player;
    private float speed = 1f;
    void Start()
    {
        player = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * speed);

        if (gameObject.transform.position.z <= -15)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {

            PlayerControll playerScript = (PlayerControll)other.GetComponent(typeof(PlayerControll));
            playerScript.death();
        }
            
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public GameObject topWall;
    public GameObject bottomWall;
    public GameObject rightWall;
    public GameObject leftWall;

    public GameObject obsttacle1;
    public GameObject obsttacle2;

    private float spawnDistance = 200;

    private Vector3[] spawnPositions;
    private float startSpawnTime = 4f;
    private float endSpawnTime = 1f;
    private float numberOfquickenings = 5f;

    void Start()
    {
        float rightX = rightWall.transform.position.x;
        float leftX = leftWall.transform.position.x;
        float topY = topWall.transform.position.y;
        float botY = bottomWall.transform.position.y;

        float height = Mathf.Abs(topY) + Mathf.Abs(botY);
        float width = Mathf.Abs(leftX) + Mathf.Abs(rightX);

        Vector3 ballanceVector = new Vector3(width / 3 * 2, height / 3 * 2, 0);

        spawnPositions = new Vector3[9];

        int c = 0;
        for (int a = 1; a <= 3; a++)
        {
            for (int b = 1; b <= 3; b++)
            {
                spawnPositions[c] = (new Vector3(width/3*a, height / 3 * b, spawnDistance) - ballanceVector);
                c++;
            }
        }

        Invoke("startSpawning", startSpawnTime);
        
    }

    void spawnObstacle(int numberOfObstacles)
    {
        List<int> positions = new List<int>();
        for (int a = 0; a < numberOfObstacles; a++)
        {
            int randi = Random.Range(0, 9);
            while (positions.Contains(randi))
            {
                randi = Random.Range(0, 9);
            }

            positions.Add(randi);
        }


        foreach (int element in positions)
        {
            int busz = Random.Range(0, 2);
            if (busz == 0)
            {
                Instantiate(obsttacle1, spawnPositions[element], Quaternion.identity);
            }
            else if (busz == 1)
            {
                Instantiate(obsttacle2, spawnPositions[element], Quaternion.identity);
            }
        }
        

    }

    void startSpawning()
    {
        StartCoroutine("DoSpawn1");
    }

    IEnumerator DoSpawn1()
    {
        for (int a = 0; a < 7; a++)
        {
            spawnObstacle(2);
            yield return new WaitForSeconds(startSpawnTime);
        }

        StartCoroutine("DoSpawn2");
    }

    IEnumerator DoSpawn2()
    {
        for (int a = 0; a < 7; a++)
        {
            spawnObstacle(3);
            yield return new WaitForSeconds(startSpawnTime);
        }

        StartCoroutine("DoSpawn3");
    }

    IEnumerator DoSpawn3()
    {
        for (int a = 0; a < 7; a++)
        {
            spawnObstacle(4);
            yield return new WaitForSeconds(startSpawnTime);
        }

        StartCoroutine("DoSpawn4");
    }

    IEnumerator DoSpawn4()
    {
        for (int a = 0; a < 7; a++)
        {
            spawnObstacle(5);
            yield return new WaitForSeconds(startSpawnTime);
        }

        StartCoroutine("DoSpawn5");
    }

    IEnumerator DoSpawn5()
    {
        for (int a = 0; a < 7; a++)
        {
            spawnObstacle(6);
            yield return new WaitForSeconds(startSpawnTime);
        }

        StartCoroutine("DoSpawn6");
    }

    IEnumerator DoSpawn6()
    {
        float interval = (startSpawnTime - endSpawnTime) / numberOfquickenings;

        for (float speed = startSpawnTime; speed > endSpawnTime; speed -= interval)
        {
            for (int a = 0; a < 7; a++)
            {
                spawnObstacle(7);
                yield return new WaitForSeconds(speed);
            }
        }

        for (;;)
        {
            spawnObstacle(7);
            yield return new WaitForSeconds(endSpawnTime);
        }

    }
}

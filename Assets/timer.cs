using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TImer;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
            
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("F1");

        TImer.text = minutes + ":" + seconds;
    }
}

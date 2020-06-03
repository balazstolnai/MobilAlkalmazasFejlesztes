using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Point;
    int i = 0;
    void Start()
    {
        InvokeRepeating("pluszegy", 0f, 2f);

    }
    void pluszegy ()
    {
        i++;
        Point.text = i.ToString();
    }

    // Update is called once per frame
    void Update()
    {


    }
}

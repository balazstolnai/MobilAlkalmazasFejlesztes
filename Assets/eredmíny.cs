using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eredmíny : MonoBehaviour
{
    // Start is called before the first frame update
    public Text eredmény;
    public Text valami;
    void Start()
    {
        eredmény.text = "Pontok: " + valami.text;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

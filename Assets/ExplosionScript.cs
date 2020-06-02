using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("endplosion", 3.5f);
    }

    private void endplosion()
    {
        Destroy(gameObject);
    }
  
}

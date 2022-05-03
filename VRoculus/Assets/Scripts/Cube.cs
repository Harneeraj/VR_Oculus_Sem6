using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

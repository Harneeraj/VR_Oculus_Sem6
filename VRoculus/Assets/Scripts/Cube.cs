using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    Vector3 rand;
    float speedRand;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
        var size = Random.Range(30, 300);
        transform.localScale = new Vector3(size, size, size);

        rand = new Vector3(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5));
        speedRand = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rand * speedRand * Time.deltaTime);
    }
}

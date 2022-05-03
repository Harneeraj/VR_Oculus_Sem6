using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class SpeedChanger : MonoBehaviour
{
    [SerializeField] SplineFollower script;

    [SerializeField] float speed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            script.followSpeed = speed;
        }
    }
}

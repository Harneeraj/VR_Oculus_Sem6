using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class BuggyHandler : MonoBehaviour
{
    [SerializeField] SplineFollower splineFollowerScript;
    [SerializeField] float StartSpeed;

    private void Start()
    {
        splineFollowerScript.followSpeed = 4;
    }

    private void Update()
    {

    }
}

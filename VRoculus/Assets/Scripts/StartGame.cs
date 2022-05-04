using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class StartGame : InteractionManager
{
    [SerializeField] SplineFollower splineFollowerScript;
    [SerializeField] float StartSpeed;

    bool isDone = false;

    public override void Implement()
    {
        if(!isDone)
        {
            splineFollowerScript.followSpeed = 4;
            isDone = true;
        }
    }
}

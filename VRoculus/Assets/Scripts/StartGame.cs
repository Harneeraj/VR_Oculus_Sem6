using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class StartGame : InteractionManager
{
    [SerializeField] SplineFollower splineFollowerScript;
    [SerializeField] float StartSpeed;

    [SerializeField] Material mat;

    MeshRenderer mesh;

    bool isDone = false;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public override void Implement()
    {
        if(!isDone)
        {
            mesh.material = mat;
            splineFollowerScript.followSpeed = 4;
            isDone = true;
        }
    }
}

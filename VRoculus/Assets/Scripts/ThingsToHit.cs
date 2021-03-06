using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingsToHit : InteractionManager
{
    [SerializeField] Material hitMat;

    MeshRenderer mesh;

    [SerializeField] int Scory;

    bool isShot = true;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public override void Implement()
    {
        if(isShot)
        {
            mesh.material = hitMat;
            GameObject.FindGameObjectWithTag("UIA").GetComponent<Score>().Counter += Scory;
            isShot = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shhot : MonoBehaviour
{
    [SerializeField] ParticleSystem vfx;

    [SerializeField] Transform firePoint;

    [SerializeField] Rigidbody bullet;

    [SerializeField] LayerMask WhatToShoot;

    [SerializeField] float sphereRadius = 5;

    [SerializeField] float speed;

    RaycastHit hit;

    private void Update()
    {
        
    }

    public void Shoot()
    {
        ByRaycasting();
        //BySphereCasting();

    }

    void BySphereCasting()
    {
        if(Physics.SphereCast(firePoint.position, sphereRadius,firePoint.forward, out hit, 5000, WhatToShoot))
        {
            vfx.Play();
            var Interact = hit.transform.GetComponent<InteractionManager>();
            if (Interact != null)
            {
                Interact.Implement();
            }
            Debug.Log(hit.transform.name);
        }
    }

    void ByRaycasting()
    {
        if (Physics.Raycast(firePoint.position, firePoint.forward, out hit, 5000))
        {
            vfx.Play();
            var Interact = hit.transform.GetComponent<InteractionManager>();
            if (Interact != null)
            {
                Interact.Implement();
            }
            Debug.Log(hit.transform.name);
        }
    }
}

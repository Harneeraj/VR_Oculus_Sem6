using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shhot : MonoBehaviour
{


    [SerializeField] Transform firePoint;

    [SerializeField] Rigidbody bullet;

    [SerializeField] float speed;

    RaycastHit hit;

    private void Update()
    {
        
    }

    public void Shoot()
    {
        if(Physics.Raycast(firePoint.position, firePoint.forward,out hit,  5000))
        {
            Debug.Log(hit.transform.name);
        }

        //var Instance = Instantiate(bullet, firePoint.position, Quaternion.identity);
        //Instance.AddForce(firePoint.forward * speed);
        //Destroy(Instance.gameObject, 10);
    }
}

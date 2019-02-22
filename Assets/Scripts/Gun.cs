using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public Transform barrelEnd;
    public Rigidbody primaryRB;
    public Rigidbody secondaryRB;
    public float primarySpeed;
    public float secondarySpeed;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootCube();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            ShootSphere();
        }

        
      
      
    }

    public void ShootCube()
    {
        Rigidbody primaryInstance;
        primaryInstance = Instantiate(primaryRB, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        primaryInstance.AddForce(barrelEnd.forward * primarySpeed);
    }
    public void ShootSphere()
    {
        Rigidbody secondaryInstance;
        secondaryInstance = Instantiate(secondaryRB, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        secondaryInstance.AddForce(barrelEnd.forward * secondarySpeed);
    }
}

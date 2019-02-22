using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public GameObject impact;
    public GameObject sphere;
    public GameObject cube;
    public float speed = 30;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            Shoot2();
        }

        
      
      
    }

    public void Shoot()
    {  
        cube.transform.position = Camera.main.transform.position;
            Rigidbody rb = cube.AddComponent<Rigidbody>();
            Vector3 v3T = Input.mousePosition;
            v3T.z = 10.0f;
            cube.transform.LookAt(Camera.main.ScreenToWorldPoint(v3T));
            rb.velocity = Camera.main.transform.forward * 40;
            RaycastHit hit;


        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
    public void Shoot2()
    {
        sphere.transform.position = Camera.main.transform.position;
        Rigidbody rb = sphere.AddComponent<Rigidbody>();
        Vector3 v3T = Input.mousePosition;
        v3T.z = 10.0f;
        sphere.transform.LookAt(Camera.main.ScreenToWorldPoint(v3T));
        rb.velocity = Camera.main.transform.forward * 40;
        RaycastHit hit;


        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }


    }
}

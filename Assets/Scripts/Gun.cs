using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public GameObject impact;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
      
    }

    public void Shoot()
    {  GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.position = Camera.main.transform.position;
            Rigidbody rb = go.AddComponent<Rigidbody>();
            Vector3 v3T = Input.mousePosition;
            v3T.z = 10.0f;
            go.transform.LookAt(Camera.main.ScreenToWorldPoint(v3T));
            RaycastHit hit;


        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}

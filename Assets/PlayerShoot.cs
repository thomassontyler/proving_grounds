using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Camera cam;
    private float force = 20f;
    [SerializeField] private Transform muzzle;
    [SerializeField] private GameObject projectile;
    


    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootProjectile();
        }
        
    }

    void ShootProjectile()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;

        //Vector3 targetPoint;
        //if(Physics.Raycast(ray, out hit))
            //targetPoint = hit.point;
        //else
            //targetPoint = ray.GetPoint

        GameObject newProjectile = Instantiate(projectile, ray.GetPoint(1), Quaternion.LookRotation(ray.direction));
        newProjectile.GetComponent<Rigidbody>().AddForce(ray.direction * force);
        //Debug.Log(newProjectile.GetComponent<Transform>().position);
    }

}
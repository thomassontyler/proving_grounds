using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private GameObject projectile;
    private float shotDistance = 1f;


    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {

            Instantiate(projectile, transform.position + shotDistance * transform.forward, transform.rotation);
            //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        }
        
    }
}
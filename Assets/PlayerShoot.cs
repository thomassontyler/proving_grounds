using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private GameObject projectile;
    private float spawnDistance = 1f;


    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            GameObject newProjectile = Instantiate(projectile, ray.origin, transform.rotation);
            newProjectile.GetComponent<Rigidbody>().AddForce(ray.direction * 10f);
            //newProjectile.Rigidbody.AddForce(ray.direction * 10f);
                
    
            
            //Instantiate(projectile, transform.position + spawnDistance * transform.forward, transform.rotation);
        
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody rigid;
    PlayerShoot playershoot;
    Vector3 shootDirection;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        playershoot = GetComponent<PlayerShoot>();
        //shootDirection = (Vector3)playershoot.GetComponent<direction>();
        //Debug.DrawRay(playershoot.ray.origin, shootDirection * 10, Color.yellow);
    
    }

    // Update is called once per frame
    void Update()
    {
        //rigid.AddForce(playershoot.direction * 10f);
    }
}

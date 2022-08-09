using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Vector3 startTransform;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        startTransform = transform.position;
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(transform.forward * 10f);
    }
}

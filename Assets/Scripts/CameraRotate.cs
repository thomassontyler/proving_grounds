using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float speed = 50.0f;
    Vector3 v3;

    void Update()
    {
        v3 = new Vector3(0.0f, Input.GetAxis("Horizontal"), 0.0f);
        transform.Rotate(v3 * speed  * Time.deltaTime);
    }
}

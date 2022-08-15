using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 2.0f;
    [SerializeField] private Transform player;
    private Vector3 initialOffset;
    // Start is called before the first frame update
    void Start()
    {
        InitVariables();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed * Time.deltaTime);
    }

    void InitVariables()
    {
        initialOffset = (transform.position - new Vector3(0, 0, 0));
    }
}

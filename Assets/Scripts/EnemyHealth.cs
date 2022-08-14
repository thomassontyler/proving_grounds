using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    private int health = 10;

    private void OnCollisionEnter(Collision collision) 
    {
        if ( health <= 0)
            Destroy(this.gameObject);
        else
            health--;
            Debug.Log(health);
    }
}

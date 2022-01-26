using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody enemy;

    private bool activated = false;


    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            enemy.velocity = new Vector3(-3, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") { 
        activated = true;
         }
    }
}

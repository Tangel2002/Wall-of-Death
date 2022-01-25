using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{


    public Rigidbody player;
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            player.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey("a"))
        {
            player.AddForce(Vector3.left * speed);
        }
        if(player.velocity.x > speed)
        {
            player.velocity = player.velocity.normalized * speed;
        }
        if (player.velocity.x < -speed)
        {
            player.velocity = player.velocity.normalized * speed;
        }
    }
}

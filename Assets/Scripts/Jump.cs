using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody player;
    public float jumpForce = 50;
    bool isGrounded = false;
    public float groundRayLength;
    public LayerMask layers;
    // Update is called once per frame


    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, -transform.up, groundRayLength, layers);
       
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            player.AddForce(Vector3.up * jumpForce);
        }
        if (-player.velocity.y > 0)
        {
            player.AddForce(Vector3.down * 5);
        }
    }
}

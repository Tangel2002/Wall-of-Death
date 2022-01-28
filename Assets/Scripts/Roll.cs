using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roll : MonoBehaviour
{


    public Rigidbody player;
    public float speed = 10;
    public string currentScene;

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
            player.velocity = new Vector3(1 * speed, player.velocity.y, 0);
        }
        if (player.velocity.x < -speed)
        {
            player.velocity = new Vector3(1 * -speed, player.velocity.y, 0);
        }

        if(player.gameObject.transform.position.y < -10)
        {
            
            SceneManager.LoadScene(currentScene);
        }
    }
}

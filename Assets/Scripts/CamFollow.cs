using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    public GameObject player;
    public new GameObject camera;


    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            camera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -13);
        }
    }
}

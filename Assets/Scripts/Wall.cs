using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Rigidbody body;
    public GameObject screen;
    void Update()
    {
        body.velocity = new Vector3(5, 0, 0);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(other.gameObject);
            if(other.gameObject.name == "Player")
            {
                screen.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}

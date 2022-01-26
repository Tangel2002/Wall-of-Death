using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Collider col;
    public Rigidbody body;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector3(5, 0, 0);


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.tag.Equals("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}

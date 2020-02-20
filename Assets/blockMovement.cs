using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMovement : MonoBehaviour
{
    public float thrust = 300.0f;
    public Rigidbody2D rb;
    public float maxSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-transform.right * thrust * Time.deltaTime);
        
    }
    void FixedUpdate() 
    {
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
//     void FixedUpdate() {
//         transform.Translate(Vector3.forward * Time.deltaTime * speed);    
//     }
}

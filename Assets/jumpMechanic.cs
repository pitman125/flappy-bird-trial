using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMechanic : MonoBehaviour
{
    public float thrust = 300.0f;
    public Rigidbody2D rb;
    private bool jumpFlag = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // When space is hit, the flag will be set 
        if (Input.GetKeyDown("space")){
            print("space key was pressed");
            jumpFlag = true;
        }
    }
    //Update once per physics cycle
    void  FixedUpdate() {

        // If flag is true the jump this physics cycle and set back to false so they can jump again
        if (jumpFlag == true){
            print("sup fam");
            rb.AddForce(transform.up * thrust);
            jumpFlag = false;
        }
    }
}

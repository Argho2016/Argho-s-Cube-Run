using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
	
	
	// Update is called once per frame
    //We used fixed update because this fuction is fixed for the entire game
	void FixedUpdate () {
        //Even out the frame rate for different pcs
        //add forward force to the object
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime ,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

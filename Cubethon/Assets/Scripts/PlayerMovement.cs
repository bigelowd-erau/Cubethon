using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //the player object's rigid body
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysforce;

    // Fixedupdate is called at a fixed time interval
    void FixedUpdate()
    {
        //adds a consistent forward force to the player object
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        
        //if d is pressed on the keyboard
        if (Input.GetKey("d"))
        {   
            //adds a velocity change force to the player relative right 
            rb.AddForce(sidewaysforce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        //if a is pressed on the keyboard
        if (Input.GetKey("a"))
        {
            //adds a velocity change force to the player relative left
            rb.AddForce(-sidewaysforce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        //check if the player has fallen off the map
        if (rb.position.y < -1f)
        {
            //reset the level
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

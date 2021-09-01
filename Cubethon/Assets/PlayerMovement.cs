using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sidewaysforce = 500f;
    public float jumpForce = 1f;
    public float jumpCoolDown = 25;
    private float currentJumpCooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
        rb.AddForce(sidewaysforce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
        rb.AddForce(-sidewaysforce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("space"))
        {
            if (currentJumpCooldown < 0)
            {
                rb.AddForce(0,jumpForce, 0, ForceMode.VelocityChange);
                currentJumpCooldown = jumpCoolDown;
            } else {
                --currentJumpCooldown;
            }
        }
    }
}

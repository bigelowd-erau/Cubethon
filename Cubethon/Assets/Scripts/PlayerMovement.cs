using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysforce;
    public float jumpForce;
    public float jumpCoolDown;
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
        /*if (Input.GetKey("space"))
        {
            if (currentJumpCooldown < 0)
            {
                rb.AddForce(0,jumpForce, 0, ForceMode.Impulse);
                currentJumpCooldown = jumpCoolDown;
            } else {
                --currentJumpCooldown;
            }
        }*/

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

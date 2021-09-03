
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //when the player collides with another object
    void OnCollisionEnter(Collision collision)
    {
        //if the object collided into has a tag of obstacle
        if (collision.collider.tag == "Obstacle")
        {
            //disable player movment script
            movement.enabled = false;
            //call end game to reset the level
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}

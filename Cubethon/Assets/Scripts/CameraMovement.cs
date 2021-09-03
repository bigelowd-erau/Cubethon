using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //set the camera position to the player position
        //transformed by the offset defined in the editor
        transform.position = player.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // The player to follow
    public Vector3 offset;   // Offset from the player

    void LateUpdate()
    {
        // Update camera position to follow the player with the given offset
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}

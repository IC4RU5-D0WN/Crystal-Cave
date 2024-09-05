using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public float smoothing = 0.125f;  // Smoothing factor for the camera movement
    public Vector3 offset;  // Offset from the player's position

    void FixedUpdate()
    {
        Vector3 targetPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothing);
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }

}

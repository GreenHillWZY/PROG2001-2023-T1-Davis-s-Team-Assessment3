using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    public Vector3 startPosition; // Start position
    public Vector3 endPosition; // End position
    public float speed; // Speed of movement

    private Vector3 targetPosition; // Next position to move to

    void Start()
    {
        // Set initial target position to the starting position
        targetPosition = startPosition;
    }

    void Update()
    {
        // Move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // If we've reached our target position, switch to the other position
        if (transform.position == targetPosition)
        {
            if (targetPosition == startPosition)
            {
                targetPosition = endPosition;
            }
            else
            {
                targetPosition = startPosition;
            }
        }
    }
}

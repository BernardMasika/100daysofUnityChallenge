using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 endPoint; // The target position where the object should move
    public float moveSpeed = 1f; // Speed of the movement
    public Vector3 scaleIncrease; // Total amount to increase the scale by
    private Vector3 initialScale; // To remember the starting scale
    private bool hasReachedEndPoint = false; // Flag to indicate when the object has reached the endPoint

    void Start()
    {
        initialScale = transform.localScale; // Store the initial scale of the object
    }

    void Update()
    {
        // Move the object upwards at a constant speed until it reaches the endPoint
        if (!hasReachedEndPoint)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;

            if (transform.position.y >= endPoint.y)
            {
                hasReachedEndPoint = true; // Mark that the endPoint has been reached
            }
        }
        else // Once the endPoint is reached, start increasing the scale
        {
            // Calculate the new scale, but do not exceed initialScale + scaleIncrease
            Vector3 targetScale = initialScale + scaleIncrease;
            transform.localScale = Vector3.Min(transform.localScale + scaleIncrease * Time.deltaTime, targetScale);
        }
    }
}

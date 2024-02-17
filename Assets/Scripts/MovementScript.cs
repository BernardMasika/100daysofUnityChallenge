using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Vector3 endPoint;

    public float moveSpeed;
    
    private bool hasReachedLimit;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    private void Update()
    {
        if (hasReachedLimit) return;
        
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        
        if (transform.position.y <= endPoint.y)
        {
            hasReachedLimit = true;
        }
        
    }
}

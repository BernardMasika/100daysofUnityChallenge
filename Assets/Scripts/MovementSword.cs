using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSword : MonoBehaviour
{
    public Vector3 _finalPoint;

   public bool _hasReachedTheFinalPoint;

    public float _moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_hasReachedTheFinalPoint) return;
        transform.position += Vector3.down * _moveSpeed * Time.deltaTime;

        if (transform.position.y <= _finalPoint.y)
        {
            _hasReachedTheFinalPoint = true;
        }
    }
}

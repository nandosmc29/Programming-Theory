using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //start
    protected SpeedManager speedManager;
    private Vector3 currentDirection;

    private const float xBoundary = 11.0f;
    
    void Start()
    {
        speedManager = GameObject.Find("SpeedManager").GetComponent<SpeedManager>();
        currentDirection = Vector3.right;
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(Direction() * Time.deltaTime * speedManager.Speed);
    }

    protected Vector3 Direction()
    {
        if (transform.position.x >= xBoundary || transform.position.x <= -xBoundary)
        {
             return currentDirection *= -1;
        }
        else
        {
            return currentDirection;
        }
    }

}

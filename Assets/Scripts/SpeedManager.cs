using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    private float speed = 10.0f;

    public float Speed
    {
        get { return speed; }
        set { if(value >= 1) { speed = value; } }
    }

    public void increaseSpeed()
    {
        Speed++;
    }

    public void decreaseSpeed()
    {
        Speed--;
    }
}

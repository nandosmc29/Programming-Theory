using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : Movement
{
    // Start is called before the first frame update
    protected override void Move()
    {
        transform.Translate(Direction() * Time.deltaTime * (speedManager.Speed+1));
    }
}

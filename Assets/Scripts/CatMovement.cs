using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CatMovement : Movement
{
    //POLYMORPHISM
    protected override void Move()
    {
        transform.Translate(Direction() * Time.deltaTime * (speedManager.Speed+1));
    }
}

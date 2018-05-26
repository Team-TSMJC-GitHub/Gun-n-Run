using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Vector2 speed = new Vector2(5, 5); //move speed

    public Vector2 direction = new Vector2(-2, 0); //move direction

    private Vector2 moving;

    void Update()

    {

        moving = new Vector2(

          speed.x * direction.x,

          speed.y * direction.y);

    }



    void FixedUpdate()

    {
        // set moving up the 2Drigidbody

        GetComponent<Rigidbody2D>().velocity = moving;

    }

}
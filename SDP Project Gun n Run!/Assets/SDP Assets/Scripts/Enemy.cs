using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public LayerMask enemyMask;
    public float speed;
    Rigidbody2D mybody;
    Transform myTrans;
    float myWidth;
    public GameObject Enemyprefab;

    // Use this for initialization
    void Start()
    {
        myTrans = this.transform;
        mybody = this.GetComponent<Rigidbody2D>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Check to see if theres ground in front before moving forward
        /*Vector2 lineCastPos = myTrans.position - myTrans.right * myWidth;
        Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
        bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
        */

        //Always move forward
        Vector2 myVel = mybody.velocity;
        myVel.x = -speed;
        mybody.velocity = myVel;

        Destroy(gameObject, 8f);        
    }


}
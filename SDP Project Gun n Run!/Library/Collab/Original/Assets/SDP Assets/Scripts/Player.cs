using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Use this for initialization
    /*When declaring:
     *Identify whether it will be public or private.
     *Data Type: int, floats, bool, strings
     *Every variable has a NAME
     *option value may be assigned*/

    public GameObject laserprefab;
    public GameObject mc;

    [SerializeField]
    private float latitude;

    [SerializeField]
    private float longitude;

    [SerializeField]
    private float speed = 6.5f;

    [SerializeField]
    [Range (1, 5)]
    private float jumpForce = 1f;

    Rigidbody2D rb;

    void Start()
    {
        change_name();
        cooridinates();
        //set_position();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        shooting();
    }

    private void change_name()
    {
        string changename = "Player 1";
        name = changename;
        Debug.Log("Name: " + name); //change name of the player...
    }

    private void cooridinates()
    {
        Debug.Log("Original position\nx: " + transform.position.x + "\ny: " + transform.position.y + "\nz:" + transform.position.z);
        //Print orignal vector cooridinates to console...
        Debug.Log("Current position\nx: " + transform.position.x + "\ny: " + transform.position.y + "\nz:" + transform.position.z);
        //print the current x position of every frame to console...
    }

    private void set_position()
    {
        transform.position = new Vector3(0, 0, 0); //set postion...
    }

    private void movement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        }
    }

    private void shooting()
    {
        //This condition states whenever I press space key down, it will be set to true.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if condition is true, spawn a laser...
            Instantiate(Instantiate(laserprefab, transform.position + new Vector3(3, 0, 0), Quaternion.identity));
        }
    }
}

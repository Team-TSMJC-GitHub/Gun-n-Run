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

    [SerializeField]
    private float latitude;
    [SerializeField]
    private float longitude;
    [SerializeField]
    private float speed = 6.5f;

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
        boundaries();
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
        //Mapping these two variables to the unity horizontal(x) and vertical(y) position.
        latitude = Input.GetAxis("Horizontal");
        longitude = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * latitude * speed); //default speed is 1m/s but we can increase this by simply multiplying the time by the number you prefer; e.g 4m/s -> * 4
        //transform.Translate(new Vector3(1,0,0)); Alternative way to translate object...
        //Move Forward... 
        transform.Translate(Vector3.up * Time.deltaTime * longitude * speed);
        Debug.Log("new x position: " + transform.position.x);
    }

    private void boundaries()
    {
        //Setting my boundry for the game...
        if (transform.position.x <= -8.3f)//when player goes out of the page on the left side, appear to the right...
        {
            transform.position = new Vector3(8.3f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 8.3f)//when player goes out of page on the right side, appear to the left...
        {
            transform.position = new Vector3(-8.3f, transform.position.y, transform.position.z);
        }
        else if (transform.position.y >= 6f)//when player goes out of the page on the top side, appear on the bottom...
        {
            transform.position = new Vector2(transform.position.x, -6f);
        }
        else if (transform.position.y <= -6f)//when player goes out of the page on the bottom side, appear on the top...
        {
            transform.position = new Vector2(transform.position.x, 6f);
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

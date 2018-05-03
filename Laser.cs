using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float speed = 10f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move laser upwards with the spd of 10 and current real time...
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        //delete game object when out of page...
        if (transform.position.x > 9f)
        {
            Destroy(this.gameObject);
        }
    }
}
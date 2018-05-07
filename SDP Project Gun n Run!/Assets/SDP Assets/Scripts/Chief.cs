using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chief : MonoBehaviour
{
    float speed = 5f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        Destroy(gameObject, 8f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Laser")
        {
            KillsScript.killValue += 0.5f;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        /*else if(other.tag == "Enemy")
        {

        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsScript : MonoBehaviour {

    public static double killValue = 0;
    Text kills;

	// Use this for initialization
	void Start () {
        kills = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        kills.text = "Kills: " + killValue; 
		
	}
}

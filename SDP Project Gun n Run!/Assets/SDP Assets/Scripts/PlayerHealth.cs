using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    // Use this for initialization
    public int startinghealth = 100;
    public int currenthealth;
    public Slider HealthSlider;
    Player playerbehaviour;
    bool isdead;
    bool damaged;

    private void Awake()
    {
        playerbehaviour = GetComponent<Player>();
        currenthealth = startinghealth;
    }

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        damaged = false;
	}

    public void dmgtaken(int amount)
    {
        damaged = true;
        currenthealth -= amount;
        HealthSlider.value = currenthealth;

        if(currenthealth <= 0 && !isdead)
        {
            Death();
        }
    }

    void Death()
    {
        isdead = true;
        playerbehaviour.enabled = false;

    }
}

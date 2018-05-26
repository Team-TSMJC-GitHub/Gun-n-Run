using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public int hp = 5; //set total hp up 5

    public bool isBoss = true; //Boss or player


    public void Attack(int attackdamage)

    {

        hp -= attackdamage;

        if (hp <= 0)

        {
            Destroy(gameObject);    
        }

    }

    void OnTriggerEnter2D(Collider2D other)

    {

      
       Missile missile = other.gameObject.GetComponent<Missile>();

        if (missile != null)

        {

            if (missile.isBossAttack != isBoss)

            {
                Attack(missile.damage);
                // destroy missile
                Destroy(missile.gameObject); 

            }

        }

    }

}
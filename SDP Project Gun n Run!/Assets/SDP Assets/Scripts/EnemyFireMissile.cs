using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMissile : MonoBehaviour
{

    public GameObject enemyMissilePrefab;
    public float missileSpeed;
    private int timeCount = 0;

    void Update()
    {

        timeCount += 1;


        if (timeCount % 60 == 0)
        {


            // generate enemy's missile
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity) as GameObject;

            Rigidbody enemyMissileRb = enemyMissilePrefab.GetComponent<Rigidbody>();

            // decide the direction of missile."right" is point at the x axis.
            enemyMissileRb.AddForce(transform.right * missileSpeed);

            // eliminate the missile after 10 sec
            Destroy(enemyMissile, 10.0f);

        }
    }
}
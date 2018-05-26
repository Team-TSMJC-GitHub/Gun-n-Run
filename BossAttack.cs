using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour {

    public Transform BossMissilePrefab; //prefab missile for boss

    public float missileTime = 0.2f; //attack in 2 sec

    private float missileCooldown;

    void Start()
    {
        missileCooldown = 0f;
    }

    void Update()

    {
        if (missileCooldown > 0)
        {
            missileCooldown -= Time.deltaTime;
        }
    }

    public void Shot(bool isBoss)

    {

        if (CanShot)

        {

            missileCooldown = missileTime;
           
            var BossMissileTransform = Instantiate(BossMissilePrefab) as Transform; //generate a new shot

            BossMissileTransform.position = transform.position; //position
            
            Missile missile = BossMissileTransform.gameObject.GetComponent<Missile>(); //script from Missile

            if (missile != null)
            {
                missile.isBossAttack = isBoss;
            }

            // Make boss attack towards 

            Move move = BossMissileTransform.gameObject.GetComponent<Move>(); //script from move

            if (move != null)

            {

                move.direction = this.transform.right; // towards in the right

            }

        }

    }

    public bool CanShot

    {

        get

        {

            return missileCooldown <= 0f;

        }

    }

}

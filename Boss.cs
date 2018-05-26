using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

    private bool hasSpawn;

    //component
    private Move move;
    private BossAttack[] attacks;
    private SpriteRenderer[] renderers;

    // Boss attack
  
    public float AttackTime = 1f;

    private float bossCooldown;
    private bool isBossAttacking;

    private Vector2 positionObject;

    void Awake()

    {
        
        attacks = GetComponentsInChildren<BossAttack>();

        move = GetComponent<Move>();

        
        // Get the renderers 

        renderers = GetComponentsInChildren<SpriteRenderer>();

    }

    void Start()

    {
        hasSpawn = false;

        //not available
        GetComponent<Collider2D>().enabled = false;

        // movement
        move.enabled = false;

        // Attack

        foreach (BossAttack attack in attacks)//loop

        {

            attack.enabled = false;

        }
        
        //boss attack behavior
        isBossAttacking = false;
        bossCooldown = AttackTime;

    }



    void Update()

    {

        if (hasSpawn == false)

        {
                BossSpawn();
        }

        else

        {
            bossCooldown -= Time.deltaTime; //move or attack

            if (bossCooldown <= 0f)

            {

                isBossAttacking = !isBossAttacking;

                bossCooldown = AttackTime;

                positionObject = Vector2.zero;

            }



            // Boss Attack    

            if (isBossAttacking)

            {

                // Stop movement

                move.direction = Vector2.zero;
               foreach (BossAttack attack in attacks)

                {

                    if (attack != null && attack.enabled && attack.CanShot)

                    {

                        attack.Shot(true);

                    }

                }

            }

           //moving

            else

            {

                // define the object
                if (positionObject == Vector2.zero)

                {

                    //random postion of the object
                    Vector2 random = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f));



                    positionObject = Camera.main.ViewportToWorldPoint(random);

                }



               //if  overlap the position

                if (GetComponent<Collider2D>().OverlapPoint(positionObject))

                {

                   //reset the position

                    positionObject = Vector2.zero;

                }

                //move to the position
                Vector3 direction = ((Vector3)positionObject - this.transform.position);
                move.direction = Vector3.Normalize(direction);

            }

        }

    }



    private void BossSpawn()

    {

        hasSpawn = true;   //when boss spwans

        GetComponent<Collider2D>().enabled = true;

        // movement

        move.enabled = true;

        // attack

        foreach (BossAttack attack in attacks)

        {

            attack.enabled = true;

        }


    }



    void OnTriggerEnter2D(Collider2D other)

    {

        // Taking damage

        Missile missile = other.gameObject.GetComponent<Missile>();

        if (missile != null)

        {

            if (missile.isBossAttack == false)

            {

                // Stop attacks and start moving 

                bossCooldown = AttackTime;
                isBossAttacking = false;

            }

        }

    }



  

}
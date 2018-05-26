using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public int damage = 1; //damage infliction

    public bool isBossAttack = false; // damage to player or boss

    void Start()

    {

        Destroy(gameObject, 10); // 10sec

    }

}
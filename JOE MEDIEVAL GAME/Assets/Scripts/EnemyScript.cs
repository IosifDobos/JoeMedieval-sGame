using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int enemyhealth = 50;


    // Update is called once per frame
    void Update()
    {
        //if enemy health is less than zero destroy the enemy object and remove it from the game
        if (enemyhealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DeductPoints(int hitpoints)
    {
        //decrement the enemy points
        enemyhealth -= hitpoints;
    }
}

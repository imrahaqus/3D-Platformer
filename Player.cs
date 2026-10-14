using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player took " + damage + " damage. Current health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, 
        attackPoint.
        position, attackPoint.
        rotation);
        }
    }

    public void CollectCoin()
    {
        coins++;
        print(coins);
    }
}

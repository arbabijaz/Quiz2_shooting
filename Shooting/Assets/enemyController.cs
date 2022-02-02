using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public float health = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthChecker();
    }
    void healthChecker()
    {
        if (health < 1)
        {
            death();
        }
    }
    public void getDamage(float damage)
    {
        health -= damage;
    }
    void death()
    {
        Debug.Log("Enemy Killed");
        Destroy(gameObject);
    }
}

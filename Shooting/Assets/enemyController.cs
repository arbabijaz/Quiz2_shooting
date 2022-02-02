using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public float health = 150;
    public float speed = 30;
    private Vector3 lookDirection;
    private GameObject player;
    private Rigidbody enemyRB;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        lookDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(lookDirection * speed* Time.deltaTime);
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
        player.GetComponent<playerController>().gotKill();
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Enemy Killed By Wall or Player");
            Destroy(gameObject);
        }
    }
}

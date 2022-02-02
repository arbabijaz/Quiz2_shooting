using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody player;
    public float speed = 5f;
    public float rotationspeed = 150f;
    private float horizontalInput;
    private float verticalInput;
    public float health = 100;
    public int kills = 0;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            playerMovement();
        }
        
        healthChecker();
    }
    void playerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        player.transform.Rotate(Vector3.up * horizontalInput * rotationspeed * Time.deltaTime);
        player.transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);  
    }
    void healthChecker()
    {
        if (health < 1)
        {
            death();
        }
    }
    void death()
    {
        Debug.Log("Player Died You loose");
        isAlive = false;
        //Destroy(gameObject);
    }
    public void gotKill()
    {
        kills += 1;
    }
    void takeDamage(float damage)
    {
        health -= damage;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health -= 10;
        }
    }
}

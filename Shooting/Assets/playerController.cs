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

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();

    }
    void playerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        player.transform.Rotate(Vector3.up * horizontalInput * rotationspeed * Time.deltaTime);
        player.transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
    }
    void takeDamage(float damage)
    {
        health -= damage;
    }
}

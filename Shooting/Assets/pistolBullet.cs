using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolBullet : MonoBehaviour
{
    public float speed = 100;
    private Rigidbody bulletRB;
    public float hitForce = 20;
    float damage = 40;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //bulletRB.AddForce(Vector3.forward);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemyController>().getDamage(damage);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * hitForce, ForceMode.Impulse); //this will add a hit force in object that collided
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);                           //destroing Bullets
        }


    }
    
    
}

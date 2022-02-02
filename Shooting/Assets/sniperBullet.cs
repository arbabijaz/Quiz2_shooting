using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperBullet : MonoBehaviour
{
    public float speed=100;
    private Rigidbody bulletRB;
    public float hitForce = 20;
    float damage = 120;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //bulletRB.AddForce(Vector3.forward);
        transform.Translate(Vector3.forward  * speed * Time.deltaTime);
    }
    void bulletdamage()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemyController>().getDamage(damage);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * hitForce, ForceMode.Impulse);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("wall")) 
        {
            Destroy(gameObject);                           //destroing Bullets
        }

        
    }
    public void onActive()
    {
        //gameObject.SetActive(true);                    //coroutine to destroy bullets automaticly showing error inactive 
        //StartCoroutine(destroyBullet());
    }
    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
}

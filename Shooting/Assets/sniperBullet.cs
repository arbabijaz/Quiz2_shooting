using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperBullet : MonoBehaviour
{
    public float speed=100;
    private Rigidbody bulletRB;
    float damage = 90;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletRB.AddForce(Vector3.forward * speed * Time.deltaTime);
        //transform.Translate(Vector3.forward );
    }
    void bulletdamage()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemyController>().getDamage(damage);
            Destroy(gameObject);
        }

        
    }
    public void onActive()
    {
        //gameObject.SetActive(true);
        //StartCoroutine(destroyBullet());
    }
    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);

    }
}

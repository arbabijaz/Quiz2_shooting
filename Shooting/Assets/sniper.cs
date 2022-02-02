using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniper : gun
{
    public GameObject sniperBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }
    }
    public override void fire()
    {
        Instantiate(sniperBullet, transform.position, transform.rotation);
        sniperBullet.GetComponent<sniperBullet>().onActive();
    }
}

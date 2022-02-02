using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgun : gun
{
    public GameObject shotgunBullet;
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
        Instantiate(shotgunBullet, transform.position, transform.rotation);

    }
}

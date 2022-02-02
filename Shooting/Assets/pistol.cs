using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : gun
{
    public GameObject pistolBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void fire()
    {
        Instantiate(pistolBullet, transform.position, transform.rotation);
        
    }
}

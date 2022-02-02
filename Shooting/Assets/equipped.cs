using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipped : MonoBehaviour
{
    public GameObject equip;
    public GameObject gun;
    private GameObject assignGun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            assignGun= Instantiate(gun, equip.transform.position, equip.transform.rotation,transform.parent);
        }
    }
}

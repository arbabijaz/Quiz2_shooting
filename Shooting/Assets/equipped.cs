using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipped : MonoBehaviour
{
    public GameObject equip;
    public GameObject[] gun;
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
            //Destroy(assignGun.gameObject);
            assignGun= Instantiate(gun[0], equip.transform.position, equip.transform.rotation,transform.parent);
            assignGun.transform.parent = equip.transform;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Destroy(assignGun.gameObject);
            assignGun = Instantiate(gun[1], equip.transform.position, equip.transform.rotation, transform.parent);
            assignGun.transform.parent = equip.transform;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Destroy(assignGun.gameObject);
            assignGun = Instantiate(gun[2], equip.transform.position, equip.transform.rotation, transform.parent);
            assignGun.transform.parent = equip.transform;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveThrower : MonoBehaviour {

    public GameObject loveAmmoPrefab;
    public Transform bulletSpawn;
    private float throwSpeed = 35.0f;
	
	void Update ()
    {       
        if(Input.GetButtonDown("Fire1"))
        {   
            Fire();
        }   
    }

    void Fire()
    {   
        var newLoveProjectile = Instantiate(loveAmmoPrefab, bulletSpawn.position, bulletSpawn.rotation);
        newLoveProjectile.GetComponent<Rigidbody>().velocity = newLoveProjectile.transform.forward * throwSpeed;
        Destroy(newLoveProjectile, 8.0f);
    }   
}

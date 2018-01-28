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
        if (bulletSpawn.position.y < 0)
        {
            Debug.Log("Achamos");
        }
        newLoveProjectile.GetComponent<Rigidbody>().velocity = newLoveProjectile.transform.forward * throwSpeed;
        EfeitosSonoros.TocarSom("Love Sound", ControleDeVolumes.volume_de_efeitos_sonoros);
        Destroy(newLoveProjectile, 8.0f);
    }   
}

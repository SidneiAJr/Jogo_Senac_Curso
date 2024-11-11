using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float projectileSpeed = 20f;

    void update(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Shoot();
        }
    }
    void Shoot()
    {
     GameObject projectile = Instantiate(projectilePrefab,shootPoint.position, Quaternion.identity);
     Rigidbody rb = projectile.GetComponent<Rigidbody>();
     if(rb != null)
     {
     rb.velocity = transform.forward * projectileSpeed; // Define a velocidade do projétil
     }
    }
}

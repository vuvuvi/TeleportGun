using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportGun : MonoBehaviour
{

    public GameObject bulletPrefab;

    public Transform bulletOriginTransform;

    public float bulletSpeed = 10f;

    public GameObject playerReference;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnShoot(InputValue value)
    { 
        if (value.isPressed)
        {
            Shoot();
        }
    
    }
    void Shoot()
    {

       GameObject newBullet = Instantiate(bulletPrefab, bulletOriginTransform.position, bulletOriginTransform.rotation);
       Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();
       bulletRigidbody.velocity = bulletOriginTransform.forward * bulletSpeed;
       TeleportBullet tpBullet = newBullet.GetComponent<TeleportBullet>();
        tpBullet.player = playerReference;

    }
}

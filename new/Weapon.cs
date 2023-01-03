using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Shoot();
            muzzleFlash.Play();
        }
    } 

    void Shoot()
    {
         nextFire = Time.time + fireRate;
         Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}


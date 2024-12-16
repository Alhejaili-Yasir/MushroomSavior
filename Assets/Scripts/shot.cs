using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform gun;
    public GameObject bulletPrefab;
    public float speed = 10f;

    void Start()
    {}



    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, gun.position, gun.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * speed;
        }
    }
}

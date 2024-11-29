using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{
    public Transform bulletSpawnPoint; // Postion where the bullet will be spawned
    public GameObject bulletPrefab;
    public float bulletSpeed = 10.0f; // Speed factor of the bullet
    public InputActionProperty shootAction;
    void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        float a = shootAction.action.ReadValue<float>();
        // if the player press the space bar or left click, then shoot
        // if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        if(a == 1)
        {
            var bullet = Instantiate(bulletPrefab); // Create a new bullet
            bullet.transform.position = bulletSpawnPoint.position; // Set the bullet position to the bulletSpawnPoint position
            // Shoot the bullet by adding velocity to the rigigbody component of the bullet
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed; 
        }
    }

}

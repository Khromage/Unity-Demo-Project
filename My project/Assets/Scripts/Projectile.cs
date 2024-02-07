using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2f;
    public float destroyTime = 5f; // Time after which the projectile is automatically destroyed

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime); // Automatically destroy the projectile after a set time to clean up
    }

    // Update is called once per frame
    void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the projectile collides with an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Here you can add what happens to the enemy upon collision
            // For example, you can destroy the enemy, deal damage, etc.

            // Destroy the projectile upon hitting an enemy
            Destroy(gameObject);
        }
    }
}
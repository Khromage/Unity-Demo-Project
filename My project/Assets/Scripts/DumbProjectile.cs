using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumbProjectile : MonoBehaviour
{
    [SerializeField]
    private float damage = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}

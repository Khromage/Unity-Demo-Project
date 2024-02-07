using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float MaxHealth, CurrentHealth;
    public AudioSource sfx;
    
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 10;
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damageAmount)
    {
        CurrentHealth = CurrentHealth - damageAmount;
        sfx.Play();
    }
}

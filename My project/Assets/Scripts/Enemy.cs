using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float MaxHealth, CurrentHealth;
    
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
<<<<<<< Updated upstream
=======
        HealthImage.fillAmount = CurrentHealth/MaxHealth;

        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
>>>>>>> Stashed changes
    }
}

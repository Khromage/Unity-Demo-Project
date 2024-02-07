using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    float MaxHealth, CurrentHealth;
    public Image HealthImage;
    
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 10;
        CurrentHealth = 5;
    }

    // Update is called once per frame
    void Update()
    {
        HealthImage.fillAmount = CurrentHealth/MaxHealth;

    }

    public void TakeDamage(float damageAmount)
    {
        CurrentHealth = CurrentHealth - damageAmount;
        HealthImage.fillAmount = CurrentHealth/MaxHealth;

        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    
}

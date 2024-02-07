using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmageddonTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        UIManager.OnArmageddon += BeginArmageddon;
    }

    void OnDisable()
    {
        UIManager.OnArmageddon -= BeginArmageddon;
    }




    private void BeginArmageddon(GameObject explosionPrefab)
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        ParticleSystem explosionVFX = explosion.GetComponent<ParticleSystem>();
        explosionVFX.Play(true);
        Destroy(explosion, 1);
    }
}

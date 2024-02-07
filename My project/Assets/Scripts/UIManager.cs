using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject ExplosionPrefab;

    public delegate void Armageddon(GameObject explosion);
    public static event Armageddon OnArmageddon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonWasPressed()
    {
        Debug.Log("BUTTON WAS PRESSED AND FUNCTION CALLED");
    }


    public void ArmageddonButtonPressed()
    {
        OnArmageddon?.Invoke(ExplosionPrefab);
    }
}

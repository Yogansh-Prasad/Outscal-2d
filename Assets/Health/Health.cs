using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    void Awake()
    {
        currentHealth = startingHealth;
    }

    
    public  void TakeDamage(float damage) 
    {
        currentHealth = Mathf.Clamp(currentHealth - damage , 0 , startingHealth);

        if (currentHealth > 0)
        {
            currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);
        }
        else 
        {
           PlayerController playerController = GetComponent<PlayerController>();
           playerController.KillPlayer();
            
        }
    }

    


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigDamage : MonoBehaviour
{
    public int currentHealth;

    public HealthBar healthbar;

    private void OnTriggerEnter()
    {
        TakeDamage(50);
    } 

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}

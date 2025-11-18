using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public int maxHealth = 200;
    public int currentHealth;
    public int deatHealth = 0;
    public GameOverScreen GameOverScreen;
    public HealthBar healthBar;



    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("You Died");
        TakeDamage(200);
        GameOverScreen.Setup(currentHealth);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        
    }




}
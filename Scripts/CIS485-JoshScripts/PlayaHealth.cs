using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayaHealth : MonoBehaviour
{

    public int maxHealth = 200;
    public int currentHealth;
    public int deatHealth = 0;
    public GameOverScreen GameOverScreen;
    public HealthBar healthBar;
    public GameObject[] obj;
 


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        obj = GameObject.FindGameObjectsWithTag("Player");
        
    }

    private void Update()
    {


        if (currentHealth <= 0)
        {
            
            Debug.Log("You Died");
            GameOverScreen.Setup(currentHealth);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.tag == "enemy")
        {
            TakeDamage(50);
            Debug.Log("hit");
        }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    

    
}

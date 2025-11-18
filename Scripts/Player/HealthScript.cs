using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthScript : MonoBehaviour
{
    public Slider slider_health;
    public float MaxHealth =100f;
    public float CurrHealth = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider_health.value = CurrHealth;
    }
}

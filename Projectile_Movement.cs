using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Movement : MonoBehaviour
{
    /// <summary>
    /// This is for the operation of the projectile
    /// This should be placed on the actual projectile that moves
    /// This is NOT for spawning projectiles
    /// </summary>

    public GameObject aProjectile;

    public float projectileSpeed;
    public float projectileTimer;

    private Rigidbody aRigidbody;

    private void Awake()
    {
        aRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        //aRigidbody.AddForce(aRigidbody.transform.forward * projectileSpeed);
        Destroy(gameObject, projectileTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(aProjectile.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Projectile_Controller : MonoBehaviour
{
    /// <summary>
    /// This is for spawning projectiles
    /// It should be placed on an empty object that is a child of the Player
    /// The empty gameobject should be placed partly in front and in and in an area that fits best
    /// Place each of the appropriate objects(sword prefab, player prefab, and camera)
    /// </summary>
    public GameObject projectile;
    public GameObject player;
    public GameObject camera;
    public Vector3 playerLocation;

    // The speed and timer are self explanatory, but can be adjusted in the inspector to what fits best
    public float projectileSpeed;
    public float projectileTimer;
    public bool powerUnlocked;

    GameObject clone;

    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Adjusts the rotation so it fits best
        // Will probably be taken out when a new object gets used instead
        transform.rotation = camera.transform.rotation;
        
        if (powerUnlocked == true)
        {
            if (Input.GetKeyDown("c"))
            {
                var rotationZ = transform.rotation.eulerAngles;
                rotationZ.x = 90;
                clone = Instantiate(projectile, transform.position, Quaternion.identity);
                clone.transform.rotation = Quaternion.Euler(rotationZ);


                clone.GetComponent<Rigidbody>().velocity = camera.transform.forward * projectileSpeed;

            }
        }
        
    }

    // Will get destroyed when coming into contact with another object
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(clone.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerAttack : MonoBehaviour
{
    public WeaponManager weapon_manager;
    public float fireRate = 15f;
    private float nextTimeToFire;
    public float damage = 20f;

    void Awake()
    {
        weapon_manager = GetComponent<WeaponManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void weaponShoot(bool is_Aiming)
    {
        if(weapon_manager.getCurrent().fireType == WeaponFireType.MULTIPLE)
        {
            if(Input.GetMouseButton(0) && Time.time > nextTimeToFire) {
                nextTimeToFire = Time.time + 1f / fireRate;

                weapon_manager.getCurrent().ShootAnimation();

                //Bullet Fired
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (weapon_manager.getCurrent().tag == Tags.AXE_TAG)
                {
                    weapon_manager.getCurrent().ShootAnimation();
                }
            } // handle shoot
            if (weapon_manager.getCurrent().bulletType == WeaponBulletType.BULLET)
            {

                weapon_manager.getCurrent().ShootAnimation();

                //BulletFired();

            }

        }
        if (is_Aiming)
        {

            weapon_manager.getCurrent().ShootAnimation();

            if (weapon_manager.getCurrent().bulletType
               == WeaponBulletType.ARROW)
            {

                // throw arrow
                //ThrowArrowOrSpear(true);

            }
            else if (weapon_manager.getCurrent().bulletType
                    == WeaponBulletType.SPEAR)
            {

                // throw spear
                //ThrowArrowOrSpear(false);

            }

        }
    }
}

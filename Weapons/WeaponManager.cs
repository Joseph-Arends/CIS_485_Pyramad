using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField]
    public WeaponScript[] weapons;

    private int currentWeaponIndex;


    // Start is called before the first frame update
    void Start()
    {
        currentWeaponIndex = 0;
        weapons[currentWeaponIndex].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { TurnOnWeapon(0); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { TurnOnWeapon(1); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { TurnOnWeapon(2); }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { TurnOnWeapon(3); }
        if (Input.GetKeyDown(KeyCode.Alpha5)) { TurnOnWeapon(4); }
    }

    void TurnOnWeapon(int weaponIndex) 
    {
        weapons[currentWeaponIndex].gameObject.SetActive(false);
        weapons[weaponIndex].gameObject.SetActive(true);
        currentWeaponIndex = weaponIndex;

    }

    public WeaponScript getCurrent()
    {
        return weapons[currentWeaponIndex];
    }
}

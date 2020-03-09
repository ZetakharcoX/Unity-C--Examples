using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeaponselect : MonoBehaviour
{
    [SerializeField] int weaponid;

    void Start()
    {
        Debug.Log("Select Weapons \n 1.Pistol 2.Smg  3.Assult Rifile 4.Lmg");    
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponid=1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponid = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponid = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            weaponid = 4;
        }

        switch(weaponid)
        {
            case 1:
                Debug.Log("You Selected a Pistol");
                break;
            case 2:
                Debug.Log("You selected a Smg");
                break;
            case 3:
                Debug.Log("You selected a AssultRifle");
                break;
            case 4:
                Debug.Log("You selected a Lmg");
                break;
           // default:
               // Debug.Log("Invalid selection");
               // break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermain : MonoBehaviour
{
    itemdbbehaviour access;
    public itemlist[] Playerinventory;
    
    void Start()
    {
        access = GameObject.Find("Advanced Player").GetComponent<itemdbbehaviour>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            access.Additems(0,this);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            access.Removeitems(0,this);
        }

        
    }

}

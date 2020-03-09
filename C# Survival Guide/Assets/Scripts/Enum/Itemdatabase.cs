using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemdatabase : MonoBehaviour
{
    public List<Itemtraits> Itemdb = new List<Itemtraits>();
    Itemtraits alteritem = new Itemtraits();
    
    
    void Start()
    {
        Itemdb[0].Selecteditem(0);    
    }

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Itemdb[0].iname = "Double Blade";
            Itemdb[0].Selecteditem(2);
        }    
    }
}

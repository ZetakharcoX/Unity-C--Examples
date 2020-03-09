using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classcustom : MonoBehaviour
{
    [SerializeField]
    public Inventory knife;
    public Inventory pistol;
    public Inventory smg;

    void Start()
    {
        knife = new Inventory();
        knife.Id = 1;
        knife.name = "Knife";
        knife.description ="Melee Weapon";
        knife.health = 100;

        pistol = new Inventory(2,"Pistol","Short range",80);

        smg = Items (3,"SMG","Medium Range", 70);
        
    }

   
    void Update()
    {
        
    }

    private Inventory Items (int i, string name , string description , int health )
    {
        var item = new Inventory(i,name,description,health);
        return item;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    public int Id;
    public string name;
    public string description;
    public int health;

    public Inventory()
    {

    }

    public Inventory (int id, string name, string description , int health)
    {
        this.Id = id;
        this.name = name;
        this.description = description;
        this.health = health;
    }
}

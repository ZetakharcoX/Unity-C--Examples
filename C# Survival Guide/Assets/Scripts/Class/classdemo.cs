using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    public string name;
    public float firingrate;
    public int ammo;
    public int damage;

    public Weapons()                                                        //Default Constructor
    {

    }

    public Weapons(string name, float firingrate , int ammo, int damage)
    {
        this.name = name;
        this.firingrate = firingrate;
        this.ammo = ammo;
        this.damage = damage;
        
    }
}

public class classdemo : MonoBehaviour
{
    private Weapons laser;
    private Weapons rockets;
    
    void Start()
    {
       laser = new Weapons();
        laser.name = "Laser";
        laser.firingrate = .35f;
        laser.ammo= 200;
        laser.damage = 45;

        rockets = new Weapons();
        rockets.name = "Rockets";
        rockets.firingrate = .5f;
        rockets.ammo = 5;
        rockets.damage = 100;
        
    //laser = new Weapons("laser",.25f,200,50);
    //rockets = new Weapons("Rockets",.6f,5,100);
    Debug.Log(" Current Weapon u selected" +laser.name + " has " + laser.damage + " damage and " + laser.ammo +" ammo remain" );
    
    }

    
    void Update()
    {
        
    }


    
}

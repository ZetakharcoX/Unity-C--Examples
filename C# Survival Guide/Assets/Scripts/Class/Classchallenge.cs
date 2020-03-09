using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customerinformation
{
    public string Fname;
    public string Lname;
    public int Age;
    public string Gender;
    public string Occupation;

    public Customerinformation()
    {

    }

    public Customerinformation(string fname, string lname,int age,string gender, string occupation)
    {
        this.Fname = fname;
        this.Lname = lname;
        this.Age = age;
        this.Gender = gender;
        this.Occupation = occupation;
    }

}


public class Classchallenge : MonoBehaviour
{
   /* [SerializeField]
    public Customerinformation maya; 
    public Customerinformation sam;
    public Customerinformation dev;
    */
    [SerializeField]
    public Customerinformation[] Customers;

    void Start()
    {
        /*
        maya = new Customerinformation("Maya","K",22,"Female","Student");
        sam = new Customerinformation("Sam","Skyoo",24,"Male","Supervisior");
        dev = new Customerinformation("Dev","Ajay",20,"Male","Student");
        */
    }

    
    void Update()
    {
        
    }
}

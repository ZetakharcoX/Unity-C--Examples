using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parttimeemployee : Employeechallenge
{
    public float Hoursworked;
    public float hourlyrate;
    

    public override void calculatemonthlysalary()
    {
        float i = Hoursworked * hourlyrate;
        Debug.Log("parttime Monthly salary "+i);
    }
}

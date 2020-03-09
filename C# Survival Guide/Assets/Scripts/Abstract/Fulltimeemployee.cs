using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fulltimeemployee : Employeechallenge
{
    public int salary;

    public override void calculatemonthlysalary()
    {
        Debug.Log("Monthly salary "+salary);
    }

}

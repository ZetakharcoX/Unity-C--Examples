using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank 
{
    public string name;
    public string Location;
    public int cashinvault;

    public void Checkbalance()
    {
        Debug.Log("Check balance in" + name);
    }

    public void Withdrawl()
    {
        Debug.Log("Withdrawl money from :" + name);
    }

    public void Deposit()
    {
        Debug.Log("Cash deposited to :"+name);
    }
   
    
}

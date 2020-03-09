using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propertieschallange : MonoBehaviour
{
    private int Speed = 95;
    private string Myname;

    public int speed
    {
        get
        {
            return Speed;
        }
    }

    public string myname
    {
        get
        {
            return Myname;
        }

        set
        {
            Myname = value;
        }
    }

    void Start()
    {
        myname = "Gokul";
        Debug.Log(""+myname+" Speed :"+speed);
        
    }    
  
}

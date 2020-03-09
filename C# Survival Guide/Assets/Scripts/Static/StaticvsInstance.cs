using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players
{
    public int name;
    public int level;
    public static int Countplayers;

    public Players()
    {
        Countplayers++;
    }
}

public class StaticvsInstance : MonoBehaviour
{
    public Players one;
    public Players two;
    public Players three;

    void Start()
    {
        one = new Players();
        two = new Players();
        three = new Players();
        Debug.Log("No of Players Joined :"+ Players.Countplayers );
    }

   
    void Update()
    {
        
    }
}

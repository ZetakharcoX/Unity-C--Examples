using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Acitonmain : MonoBehaviour
{
   // public delegate void Damagereceived(int dam);
    //public static event Damagereceived damrec;

    public static Action<int> damrec;
    public Func<string,int> charlen;

    public int health {get; set;}

    private void Start()
    {
        health = 10;
    }

    public void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
           health--;
           charlen += getcharlen;
           int i = charlen("Gokul");
           Debug.Log("Func Delegate Working: " + i);


        if (damrec != null)
            damrec(health);
       }
    }

    int getcharlen(string name)
    {
        return name.Length;
    }

}

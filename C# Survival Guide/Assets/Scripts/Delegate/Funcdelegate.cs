using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Funcdelegate : MonoBehaviour
{ 
    public delegate int getchar(string sname);
    getchar charcount;
    public Func<string,int> funcgetchar;
    public Func<string,int> Funclambda;

    void Start()
    {
        charcount = getstring;
        int count = charcount("Gokul");
        Debug.Log("Gokul Char Count: "+count);
        funcgetchar = getstring;
        int count2 = funcgetchar("Raj");
        Debug.Log("Raj Char Count is " +count2+ "using Func delegate");

        Funclambda = (name) => name.Length;
        int count3 = Funclambda("GokulRaj");
        Debug.Log("Using lambda operator");

    }

    int getstring (string name)
    {
        return name.Length;
    }

    
}

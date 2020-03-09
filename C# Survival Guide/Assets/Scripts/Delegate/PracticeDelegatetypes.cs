using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PracticeDelegatetypes : MonoBehaviour
{
    public Action<int,int> Sum;                   //RETURN TYPE VOID AND TAKING TWO INT PARAMETERS

    private void Start()
    {
        Sum = twosum;
        Sum(99,99);
        Sum = (n1,n2) =>{
                        var total = n1+n2;
                        if (total<500)
                            Debug.Log("Score is lower"+ total);
                        else
                            Debug.Log("Score is Higher"+ total);
                        };
        Sum(200,99);
    }

    public void twosum(int a,int b)
    {
        int total1 = a+b;
        Debug.Log("Sum Total is "+total1);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopchallenge : MonoBehaviour
{
    int i=1;
    void Start()
    {
     /*    do                                                           // My Method 
        {
            Debug.Log(i);
            i++;
        }
        while (i <=10);

        for (int j=0;j<20;j++)
        {
            if (j%2 == 0)
                Debug.Log("Even Numbers From 0 To 20 : "+ j);
        }

        for (int j=0 ; j < 30 ; j++)
        {
            if(j%2 == 1)
                Debug.Log("Odd Numbers From 0 To 30 :" + j);
        }
        */

        for (int j = 0 ; j < 30 ; j++)
        {
            if (j<10)
                Debug.Log("Numbers : " + j);
            if (j > 9 && j<=20)
            {
                if (j % 2 == 0)
                Debug.Log("Even Number : " + j);
            }

            if (j>20 && j <30)
            {
                if (j%2 == 1)
                    Debug.Log("Odd Number : " + j);
            }
        }
    }

    
    void Update()
    {
        
    }
}

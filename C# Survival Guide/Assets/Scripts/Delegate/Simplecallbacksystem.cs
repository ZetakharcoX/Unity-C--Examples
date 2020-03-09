using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Simplecallbacksystem : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Callback (() =>   {

                                        Debug.Log("Routine Finished");

                                         }));
    }

    public IEnumerator Callback(Action whencomplete = null)
    {
        yield return new WaitForSeconds(5f);

        //Debug.Log("Rotine Finshed");
        if (whencomplete != null)
            whencomplete();
    } 

   
}

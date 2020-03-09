using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopchallenge2 : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(Speed());
    }

   
    void Update()
    {
        
    }

    IEnumerator Speed()
    {
        for (int i = 0; i < Random.Range(60,120) ;)
        {
            Debug.Log("Current Speed is : " + i);
            i = i+5;
            yield return new WaitForSeconds(1.0f);
        }
        
    }
}

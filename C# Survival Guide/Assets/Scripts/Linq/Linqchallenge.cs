using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linqchallenge : MonoBehaviour
{
    public List<int> grades = new List<int>();
    
    void Start()
    {
        for(int i=0;i<100;i++)
        {
         grades.Add(i);  
        }

        var getgrades = grades.Where(num => num>69).OrderByDescending(g => g).Reverse();
        foreach (var obj in getgrades)
        {
             
            Debug.Log("passed grades" + obj);
            
        }


    }

    
    void Update()
    {
        
    }
}

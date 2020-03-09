using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using demo;

public class Namespaceaccess : MonoBehaviour
{
    
    void Start()
    {
        demo.Namespacedemo namespaceobj = new demo.Namespacedemo();
        namespaceobj.count = 20;
        namespaceobj.printsome();
    }

    
    void Update()
    {
        
    }
}

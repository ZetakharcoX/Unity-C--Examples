using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testbehaviour : MonoBehaviour
{
    private Statictest increase;

    void Start()
    {
       increase = GameObject.Find("Staticmanager").GetComponent<Statictest>();
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            increase.Score +=10;
            Debug.Log(increase.Score);
        }
        
    }
}

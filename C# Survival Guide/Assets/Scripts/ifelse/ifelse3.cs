using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse3 : MonoBehaviour
{
    [SerializeField]
    private static int speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)&& speed <=20)
        {
            speed = speed + Random.Range(1,5);
            Debug.Log("your speed " + speed + " km/h");
        }

        if (Input.GetKeyDown(KeyCode.S) && speed >=0 )
        {
            speed = speed - Random.Range(1,4);
            Debug.Log("your speed " + speed + " km/h");
        }
    }
}

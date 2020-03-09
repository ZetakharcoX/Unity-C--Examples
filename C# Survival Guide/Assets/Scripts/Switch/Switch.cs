using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    
    [SerializeField] private int points;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            points = 10;
        
        if (Input.GetKeyDown(KeyCode.D))
            points = 20;
        
        switch(points)
        {
            case 10:
                Debug.Log("You Have Low Point");
                break;
            case 20:
                Debug.Log("You Have High Point");
                break;
            default:
                Debug.Log("U need points");
                break;
        }
    }
}

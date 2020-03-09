using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchcubecolor : MonoBehaviour
{
    
    [SerializeField] GameObject cube;
    [SerializeField] int press;
    Renderer cubecolor;
    void Start()
    {
        cubecolor = cube.GetComponent<Renderer>();
        
    }

   
    void Update()
    {
        switch(press)
        {
            case 1:
                cubecolor.material.color = Color.blue;
                break;
            case 2:
                cubecolor.material.color = Color.red;
                break;
            case 3:
                cubecolor.material.color = Color.green;
                break;
            case 4:
                cubecolor.material.color = Color.black;
                break;
            default:
                cubecolor.material.color = Color.white;
                break;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practicaleventcube : MonoBehaviour
{
    public delegate void Cubedie();
    public static event Cubedie cubedie;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(cubedie !=null)
                cubedie();
        }    
    }
}

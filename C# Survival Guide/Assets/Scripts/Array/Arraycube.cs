using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arraycube : MonoBehaviour
{
    [SerializeField] public GameObject[] cubes;
    MeshRenderer[] cuberend;
    
    void Start()
    {
                
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          /* for (int i =0 ; i<cubes.Length ; i++)
           {
               cubes[i].GetComponent<Renderer>().material.color = Color.red;
           }
            */
           foreach(var obj in cubes)
           {
               obj.GetComponent<Renderer>().material.color = Color.red;
           }
          
            

        }
        
    }
}

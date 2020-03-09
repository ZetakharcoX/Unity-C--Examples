using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arraytest : MonoBehaviour
{
    public string[] names ;
    public int[] age = new int[5];
    public int[] rank = new int[] {1,2,3,4,5};

    
    void Start()
    {
        
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int i = Random.Range(-1,names.Length);
            Debug.Log("" + names[i]+ " age is " + age[i] + " and rank " + rank[i]);


          /*  for(int j =0 ; j<5;j++)                                                   //My Method
            {
                if(j==i)
                {
                    Debug.Log("" + names[j]+ " age is " + age[j] + " and rank " + rank[j]);
                }
            }
        */
        }

            
    }
}

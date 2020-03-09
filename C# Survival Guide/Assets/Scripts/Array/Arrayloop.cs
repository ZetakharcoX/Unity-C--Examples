using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrayloop : MonoBehaviour
{
    public string[] users;
    public int[] level;
    
    void Start()

    {

     /*   for (int i =0; i<users.Length; i++)
        {
            Debug.Log("User name is "+users[i]+" level " +level[i]);
        }
    */

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            foreach(var acc in users)
            {
                //Debug.Log(acc);
                if (acc=="manhunt")
                {
                    Debug.Log(level[6]);
                }
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawnmanager : MonoBehaviour
{
    public GameObject Enemyobj;
    Transform trans;
    public static int Enemycount;
   

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Enemyobj,transform.position,Quaternion.identity);
        }
    }
}

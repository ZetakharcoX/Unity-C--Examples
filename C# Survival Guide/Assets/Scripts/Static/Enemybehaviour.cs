using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemybehaviour : MonoBehaviour
{
    private void OnEnable() 
    {
        Enemyspawnmanager.Enemycount++;
        die();
    }

    public void OnDisable()
    {
        Enemyspawnmanager.Enemycount--;
    }

    void die()
    {
        Destroy(gameObject,Random.Range(1,7));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcoroutine : MonoBehaviour
{
    [SerializeField] private int Bullets;

    void Start()
    {
        StartCoroutine(Shoot());
    }

    
    void Update()
    {
        
    }

    IEnumerator Shoot()
    {
        for(int i =0; i<60;i++)
        {
            Debug.Log(Bullets++);
            yield return new WaitForSeconds(1.0f);        }
    }
}

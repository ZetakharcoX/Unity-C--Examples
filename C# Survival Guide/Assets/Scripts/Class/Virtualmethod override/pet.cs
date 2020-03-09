using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pet : MonoBehaviour
{
    public string pname;

    protected virtual void Sound()
    {
        Debug.Log("Sound !");
    }

    private void Start() 
    {
        Sound();    
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dog : pet
{
    
    protected override void Sound()
    {
        Debug.Log("Bark Bark !");
    }
   
}
